using AutoMapper;
using KranumCore.Extensions;
using KranumCore.ViewResource.AgencyInorm;
using KranumCore.ViewResource.Event;
using KranumDataAccess.Model;
using KranumDataAccess.Models;

namespace KranumCore.AutoMapperProfile
{
    public class AgencyInormProfile : Profile
    {
        public AgencyInormProfile()
        {
            CreateMap<ClientContactPerson, AgencyInormResponseViewResource>();

            CreateMap<AgencyInormResponseViewResource, ClientContactPerson>();
           
        }
    }
}

