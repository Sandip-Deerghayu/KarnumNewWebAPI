using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace KranumCore.ExceptionHandler
{
    public class RestException : Exception
    {
        public HttpStatusCode StatusCode { get; }
        public object DataValidationErrors { get; }

        public RestException(HttpStatusCode StatusCode, object DataValidationErrors = null)
        {
            this.StatusCode = StatusCode;
            this.DataValidationErrors = DataValidationErrors;
        }
    }
}
