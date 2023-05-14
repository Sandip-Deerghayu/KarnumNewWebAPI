using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyPlanDetail
    {
        public int Id { get; set; }
        public int? PlanId { get; set; }
        public DateTime? SuscribeDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string Status { get; set; }
        public string AgencyUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public decimal? Amount { get; set; }
        public string VaultKey { get; set; }
    }
}
