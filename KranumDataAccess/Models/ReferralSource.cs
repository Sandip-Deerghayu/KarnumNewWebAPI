using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ReferralSource
    {
        public int ReferralSourceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }
        public string ReferralCompanyUuid { get; set; }
        public string Designation { get; set; }
        public string Status { get; set; }
        public string EmailId { get; set; }
        public string ImageUrl { get; set; }
        public string ReferralSourceUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int? ClientLocationId { get; set; }
        public string InactiveReason { get; set; }
    }
}
