using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyOnCallInformationMappingLocation
    {
        public int Id { get; set; }
        public int? LocationId { get; set; }
        public string PrimaryScheduler { get; set; }
        public string SecondaryScheduler { get; set; }
        public int? AgencyOnCallInformationId { get; set; }
        public int? ClientLocationId { get; set; }
    }
}
