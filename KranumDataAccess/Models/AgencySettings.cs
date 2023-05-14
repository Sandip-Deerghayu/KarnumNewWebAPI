using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencySettings
    {
        public int Id { get; set; }
        public string AgencyUuid { get; set; }
        public string NameOfStateAgencyForAppendixL { get; set; }
        public string NameOfPersonHoldingTheInformationForAppendixL { get; set; }
        public string AddressOfPersonHoldingTheInformationForAppendixL { get; set; }
        public string AddressForDepartmentOfCommunityHealthForComplaints { get; set; }
        public string TransportationName { get; set; }
        public string TransportationContactNo { get; set; }
        public string GeoFenceRadiusForClockIn { get; set; }
    }
}
