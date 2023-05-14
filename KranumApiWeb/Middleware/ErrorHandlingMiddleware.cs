using KranumCore.ExceptionHandler;
using Microsoft.AspNetCore.Http;
using KranumDataAccess.Repository;
using System.Net;
using System.Text.Json;

namespace KranumApiWeb.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        private readonly IUnitOfWork _unitOfWork;


        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger, IUnitOfWork unitOfWork)
        {
            _next = next;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, _logger);
            }

        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex, ILogger<ErrorHandlingMiddleware> logger)
        {
            object DataValidationErrors = null;

            switch (ex)
            {
                case RestException rex:
                    logger.LogError(ex, "REST Error");
                    DataValidationErrors = rex.DataValidationErrors;
                    context.Response.StatusCode = (int)rex.StatusCode;
                    break;
                case Exception e:
                    logger.LogError(e, "Server Error");
                    DataValidationErrors = string.IsNullOrWhiteSpace(e.Message) ? "Error": ex.Message;  
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                    var routeData = context.GetRouteData();

                    string controllerName = "";
                    string actionName = "";

                    if (routeData != null)
                    {
                       controllerName = routeData.Values["controller"].ToString();
                       actionName = routeData.Values["action"].ToString();
                    }

                    await _unitOfWork.GetExceptionLogRepository().AddAsync(new KranumDataAccess.Model.ExceptionLog()
                    {
                        Uuid = Guid.NewGuid().ToString(),
                        ControllerName = controllerName,
                        ActionName = actionName,
                        Message = ex != null ? ex.InnerException.Message : "",
                        StackTrace = ex != null ? ex.StackTrace + " -- " + ex.InnerException.StackTrace : "",
                        CreatedDate = DateTime.Now
                    });

                    _unitOfWork.SaveChanges();
                    
                    break;
            }

            context.Response.ContentType = "application/json";
            if (DataValidationErrors != null)
            {
                var result = JsonSerializer.Serialize(new { DataValidationErrors });

                await context.Response.WriteAsync(result);
            }
        }
    }
}
