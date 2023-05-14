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
    public class UpdateUserNotes
    {
        public class Command : IRequest<UserNotesResponseViewResource>
        {
            public UpdateUserNotesViewResource UpdateUserNotesViewResource { get; set; }
        }

        public class Handler : IRequestHandler<Command, UserNotesResponseViewResource>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IBlobManager _blobManager;
            private readonly RelyfyDotNetStagingContext _dbContext;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IBlobManager blobManager, RelyfyDotNetStagingContext dbContext)
            {
                this._unitOfWork = unitOfWork;
                this._mapper = mapper;
                _blobManager = blobManager;
                _dbContext = dbContext;
            }

            public async Task<UserNotesResponseViewResource> Handle(Command request, CancellationToken cancellationToken)
            {
                try
                {
                    var requestedViewResource = request.UpdateUserNotesViewResource;

                    var entity = await this._unitOfWork.GetUserNotesRepository().GetAsync(requestedViewResource.Id);

                    if (entity == null)
                    {
                        throw new RestException(HttpStatusCode.NotFound, new { error = $"{requestedViewResource.Id} NOT FOUND" });
                    }

                    var errorResponse = new ErrorResponse();                    

                    var viewResource = new UserNotesViewResource()
                    {
                        Id = entity.Id,
                        UpdatedOn = DateTime.Now,
                        UUID = entity.UUID,
                        CreatedBy=entity.CreatedBy,
                        CreatedOn=entity.CreatedOn,
                        LoginUUID= requestedViewResource.LoginUUID,
                        UserUUID=requestedViewResource.UserUUID,
                        UpdatedBy = requestedViewResource.LoginUUID,
                        Notes = requestedViewResource.Notes,
                        Type = requestedViewResource.Type,
                    };

                    var dbentity = _mapper.Map<KranumDataAccess.Models.UserNotes>(viewResource);
                    dbentity.IsActive = true;
                    await this._unitOfWork.GetUserNotesRepository().UpdateAsync(dbentity);

                    
                    _unitOfWork.SaveChanges();

                    var response = _mapper.Map<UserNotesResponseViewResource>(entity);

                    return response;

                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                        case Exception exp:
                            throw exp;
                    }

                    return null;
                }
            }

        }
    }
}
