using AutoMapper;
using KranumCore.ExceptionHandler;
using KranumCore.ViewResource.Client;
using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.EventChatAgent;
using KranumDataAccess.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace KranumCore.Mediator.Event
{
    public class GetEvents
    {
        public class Query : IRequest<List<EventResponseViewResource>>
        {
            
        }

        public class Handler : IRequestHandler<Query, List<EventResponseViewResource>>
        {
            private readonly IUnitOfWork unitOfWork;
            private readonly IMapper _mapper;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                this.unitOfWork = unitOfWork;
                this._mapper = mapper;
            }
                
            public async Task<List<EventResponseViewResource>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    DateTime date = new DateTime(2022, 08, 22, 0,0,0);

                    var entity = await unitOfWork.GetClientContactPersonRepository().GetAllAsync();
                  
                    //if  (request.ShowPastEvents)
                    //{
                    //    entity = entity.Where(x => x.EndDateTime < DateTime.Now).ToList();
                    //}

                    //if (!request.ShowPastEvents)
                    //{
                    //    entity = entity.Where(x => x.EndDateTime >= DateTime.Now).ToList();
                    //}

                    if (entity == null || entity.Count == 0)
                    {   
                    }
                        throw new RestException(HttpStatusCode.NotFound, new { error = "Events not found!" });

                    var response = _mapper.Map<List<EventResponseViewResource>>(entity);

                    //return  response.OrderByDescending(x => x.ModifiedDate).ToList();
                    return response.OrderByDescending(x => x.UpdatedOn).ToList();
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                    }

                    throw new Exception("Error while getting Events", ex);
                }

            }
        }
    }
}
