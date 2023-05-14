using AutoMapper;
using KranumCore.BlobHandler;
using KranumCore.ExceptionHandler;
using KranumCore.ViewResource.AgencyInorm;
using KranumCore.ViewResource.User;
using KranumDataAccess.Models;
using KranumDataAccess.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using KranumCore.ViewResource.Error;
using System.Net;
using Newtonsoft.Json.Linq;
using KranumCore.ViewResource.UserNotes;

namespace KranumCore.Mediator.UserNotes
{
    public class DeleteUserNotes
    {
        public class Command : IRequest<bool>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Command,bool>
        {
            private readonly IUnitOfWork unitOfWork;
            public Handler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork;
            }

            public async Task<bool> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var Id = Convert.ToInt32(request.Id);
                    var entity = await this.unitOfWork.GetUserNotesRepository().GetByIdAsync(Id);                    

                    if (entity == null)
                    {
                      
                        throw new RestException(HttpStatusCode.NotFound, new { error = $"User notes {request.Id} NOT FOUND" });
                    }                  
                  
                    entity.IsActive = false;
                    await this.unitOfWork.GetUserNotesRepository().UpdateAsync(entity);
                    

                    this.unitOfWork.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                    }

                    throw new Exception("Error while deleting User Notes", ex);
                }
            }
        }
    }
}
