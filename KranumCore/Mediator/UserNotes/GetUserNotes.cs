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
    public class GetUserNotes
    {
        public class Query : IRequest<List<UserNotesViewResource>>
        {
        }

        public class Handler : IRequestHandler<Query, List<UserNotesViewResource>>
        {
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper _mapper;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.unitOfWork = unitOfWork;
                this._mapper = mapper;
            }

            public async Task<List<UserNotesViewResource>> Handle(Query request, CancellationToken cancellationToken)
            {
                var entity = await unitOfWork.GetUserNotesRepository().GetAllAsync();

                if (entity == null || entity.Count == 0)
                {
                    throw new RestException(HttpStatusCode.NotFound, new { error = "User Notes not found!" });
                }

                var response = _mapper.Map<List<UserNotesViewResource>>(entity.Where(x => x.IsActive == true).ToList());

                return response;

            }
        }

    }
}
