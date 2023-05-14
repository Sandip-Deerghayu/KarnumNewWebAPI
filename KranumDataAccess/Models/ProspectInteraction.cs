using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ProspectInteraction
    {
        public int Id { get; set; }
        public string ProspectUuid { get; set; }
        public string InteractionType { get; set; }
        public DateTime? DateOfLastCall { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string AgencyUuid { get; set; }
        public string Status { get; set; }
        public string Stage { get; set; }
        public string OtherContactUuid { get; set; }
    }
}
