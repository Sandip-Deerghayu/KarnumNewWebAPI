using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientContactInformation
    {
        public string FirstName { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string MiddleName { get; set; }
        public string Referral { get; set; }
        public string TimeZone { get; set; }
        public string Ssn { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public string Uuid { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string Location { get; set; }
        public string Marketer { get; set; }
        public string Scheduler { get; set; }
        public string PrimaryCaseManager { get; set; }
        public string Notes { get; set; }
        public string FollowUp { get; set; }
        public string CreatedBy { get; set; }
        public string ClientLocation { get; set; }
        public string UpdatedBy { get; set; }
        public string ReferralBy { get; set; }
        public string ReferralType { get; set; }
        public DateTime? DateOfFirstContact { get; set; }
        public string InactiveReason { get; set; }
        public string BusinessName { get; set; }
        public string FanCount { get; set; }
        public string County { get; set; }
        public string ContactTitle { get; set; }
    }
}
