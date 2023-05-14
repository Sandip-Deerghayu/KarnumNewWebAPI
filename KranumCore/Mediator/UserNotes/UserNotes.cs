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
    public class UserNotes
    {
        public class Command : IRequest<UserNotesResponseViewResource>
        {
            public UserNotesRequsetViewResource CreateUserNotesRequsetViewResource { get; set; }


        }

        public class Handler : IRequestHandler<Command, UserNotesResponseViewResource>
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
            private readonly IConfiguration _configuration;
            private readonly IBlobManager _blobManager;
            private readonly RelyfyDotNetStagingContext _dbContext;
            public Encoding Encoding { get; set; } = Encoding.UTF8;

            public Handler(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration configuration, IBlobManager blobManager, RelyfyDotNetStagingContext dbContext)
            {
                _mapper = mapper;
                _unitOfWork = unitOfWork;
                _configuration = configuration;
                _blobManager = blobManager;
                _dbContext = dbContext;
            }

            public async Task<UserNotesResponseViewResource> Handle(Command request, CancellationToken cancellationToken)
            {
                try { 
              var viewResource = new UserNotesViewResource()
                    {
                        UserUUID = request.CreateUserNotesRequsetViewResource.UserUUID,
                        LoginUUID = request.CreateUserNotesRequsetViewResource.LoginUUID,
                        CreatedOn = DateTime.Now,
                        UUID = Guid.NewGuid().ToString(),
                        UpdatedOn = DateTime.Now,
                        UpdatedBy = request.CreateUserNotesRequsetViewResource.LoginUUID,
                        CreatedBy = request.CreateUserNotesRequsetViewResource.LoginUUID,
                        Notes= request.CreateUserNotesRequsetViewResource.Notes,
                        Type = request.CreateUserNotesRequsetViewResource.Type,
                    };

                var entity = _mapper.Map<KranumDataAccess.Models.UserNotes>(viewResource);
                    entity.IsActive = true;
                var dbEntity = await this._unitOfWork.GetUserNotesRepository().AddAsync(entity);
                this._unitOfWork.SaveChanges();

                var response = _mapper.Map<UserNotesResponseViewResource>(entity);
                return response;
            }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                    }

                    throw new Exception("Error while creating user notes", ex);
    }
}           
        }

    }
}
