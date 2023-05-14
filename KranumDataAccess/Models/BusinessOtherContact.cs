using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BusinessOtherContact
    {
        public string FirstName { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
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
        public string Notes { get; set; }
        public string FollowUp { get; set; }
        public string CreatedBy { get; set; }
        public string ClientLocation { get; set; }
        public string UpdatedBy { get; set; }
        public string ReferralBy { get; set; }
        public string ReferralType { get; set; }
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
        public string LicensedBeds { get; set; }
        public string ControllingInterest { get; set; }
        public DateTime? OwnerSince { get; set; }
        public string Owner { get; set; }
        public string LicenseStatus { get; set; }
        public string MailingCounty { get; set; }
        public string MailingZip { get; set; }
        public string MailingState { get; set; }
        public string MailingCity { get; set; }
        public string MailingAddressLine2 { get; set; }
        public string MailingAddress { get; set; }
        public DateTime? LicenseExpirationDate { get; set; }
        public DateTime? LicenseEffectiveDate { get; set; }
        public string LicenseNumber { get; set; }
        public string Ahcanumber { get; set; }
        public string ProspectUuid { get; set; }
        public bool? Unsubscribe { get; set; }
        public bool? IsBounce { get; set; }
        public DateTime? BounceDate { get; set; }
        public DateTime? UnsubscribeDate { get; set; }
        public int? BounceMailId { get; set; }
        public int? UnsubscribeMailId { get; set; }
    }
}
