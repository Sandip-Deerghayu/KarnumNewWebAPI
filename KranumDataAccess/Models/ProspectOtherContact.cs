using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ProspectOtherContact
    {
        public string FirstName { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Fax { get; set; }
        public string LastName { get; set; }
        public string Uuid { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public string ClientLocation { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateOfFirstContact { get; set; }
        public decimal? ExpectedValue { get; set; }
        public decimal? ExpectedHourPerWeek { get; set; }
        public string InactiveReason { get; set; }
        public string County { get; set; }
        public string ContactTitle { get; set; }
        public string Fblink { get; set; }
        public string TwiterLink { get; set; }
        public string WebUrl { get; set; }
        public string ProfitStatus { get; set; }
        public string ProspectUuid { get; set; }
    }
}
