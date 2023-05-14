using AutoMapper;
using KranumCore.Extensions;
using KranumCore.ViewResource.Event;
using KranumDataAccess.Model;
using KranumDataAccess.Models;

namespace KranumCore.AutoMapperProfile
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventViewResource>();

            CreateMap<EventViewResource, Event>();

            CreateMap<Event, EventResponseViewResource>();

            CreateMap<EventResponseViewResource, Event>();

            CreateMap<Event, CreateEventRequestViewResource>();
            CreateMap<CreateEventRequestViewResource, Event>();

            CreateMap<Event, CreateEventResponseViewResource>();
            CreateMap<CreateEventResponseViewResource, Event>();

            CreateMap<Event, UpdateEventResponseViewResource>();
            CreateMap<UpdateEventResponseViewResource, Event>();
        }
    }
}

