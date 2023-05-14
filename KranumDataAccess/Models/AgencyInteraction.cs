using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyInteraction
    {
        public int InteractionId { get; set; }
        public string InteractionMode { get; set; }
        public string AgencyUuid { get; set; }
        public DateTime? InteractionDate { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string InteractionStatus { get; set; }
        public TimeSpan? InteractionTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
