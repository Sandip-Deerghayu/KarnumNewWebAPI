using AutoMapper;
using KranumCore.Extensions;
using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.UserNotes;
using KranumDataAccess.Model;
using KranumDataAccess.Models;

namespace KranumCore.AutoMapperProfile
{
    public class UserNotesProfile : Profile
    {
        public UserNotesProfile()
        {
            CreateMap<UserNotes, UserNotesViewResource>();
            CreateMap<UserNotesViewResource, UserNotes>();

            CreateMap<UserNotes, UserNotesRequsetViewResource>();
            CreateMap<UserNotesRequsetViewResource, UserNotes>();

            CreateMap<UserNotes, UserNotesResponseViewResource>();
            CreateMap<UserNotesResponseViewResource, UserNotes>();

            CreateMap<UserNotes, UpdateUserNotesViewResource>();
            CreateMap<UpdateUserNotesViewResource, UserNotes>();

        }
    }
}

