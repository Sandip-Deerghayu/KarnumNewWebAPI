using AutoMapper;
using KranumCore.ExceptionHandler;
using KranumCore.ViewResource.KranumDataMapping;
using KranumDataAccess.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace KranumCore.Mediator.KranumDataMapping
{
    public class GetKranumDataMapping
    {
        public class Query : IRequest<KranumDataMappingResponseViewResource>
        {
            public int EventUUID { get; set;}
        }

        public class Handler : IRequestHandler<Query, KranumDataMappingResponseViewResource>
        {
            private readonly IUnitOfWork _unitOfWork;
            public Handler(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
            }
                
            public async Task<KranumDataMappingResponseViewResource> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    var response = new KranumDataMappingResponseViewResource();

                    var eventEntity = await _unitOfWork.GetEventRepository().GetByIdAsync(request.EventUUID);

                    if (eventEntity == null)
                    {
                        throw new RestException(HttpStatusCode.NotFound, new { error = "Event not found!" });
                    }

                    var eventId = eventEntity.Id;
                    var eventUUID = request.EventUUID;
                    //var eventTitle = eventEntity.Title;
                    //var eventStartDate = eventEntity.StartDateTime;

                    response.EventUUID = eventUUID.ToString();
                    //response.EventTitle = eventTitle;
                    //response.EventStartDatetime = eventStartDate;

                    var loggedinUsers = new KranumDataMappingResponseViewResource();

                    //if (loggedinUsers != null && loggedinUsers.Any())
                    //{
                    //    var users = loggedinUsers.Select(x => x.User)
                    //                             .Select(x => new { x.Id, x.Uuid, x.FirstName, x.LastName, x.BusinessName, x.PhoneNumber, x.EmailId, x.SecondaryEmailId })
                    //                             .Distinct().ToList();

                    //    response.AttendedUsers = users.Select(x => new AttendedUser()
                    //    {
                    //        UserUUID = x.Uuid,
                    //        FirstName = x.FirstName,
                    //        LastName = x.LastName,
                    //        BusinessName = x.BusinessName,
                    //        PhoneNumber = x.PhoneNumber,
                    //        EmailId = x.EmailId,
                    //        SecondaryEmailId = x.SecondaryEmailId,
                    //        UserWatchedVideo = GetUserWatchedVideo(eventId, x.Id),
                    //        UserDownloadedResource = GetUserDownloadedResource(eventId, x.Id)
                    //    }).ToList();
                    //};


                    return response;
                }
                catch (Exception ex)
                {
                    switch (ex)
                    {
                        case RestException rex:
                            throw rex;
                    }

                    throw new Exception("Error while getting Event Information!", ex);
                }
            }

         
           
           }
    }
}
