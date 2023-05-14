using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyfyCustomerInformation
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public string ClientIdentifier { get; set; }
        public string InBusinessSince { get; set; }
        public string LogoImage { get; set; }
        public string IsVeraMedix { get; set; }
        public string IsVeraNutri { get; set; }
        public string RegistrationId { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string Zip { get; set; }
        public string PracticeName { get; set; }
        public string Credentials { get; set; }
        public string Registration { get; set; }
        public DateTime? LastLogin { get; set; }
        public string SkypeId { get; set; }
        public string CompanyName { get; set; }
        public string TimeZone { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string Website { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PasswordSalt { get; set; }
        public string Uuid { get; set; }
        public string Country { get; set; }
        public string DbtimeZone { get; set; }
        public string SageCompanyId { get; set; }
        public string InvoiceUniqueId { get; set; }
        public string City { get; set; }
        public string QuickBookToken { get; set; }
        public string QuickBookCompanyId { get; set; }
        public string QuickbooksClientId { get; set; }
        public string QuickbooksClientSecret { get; set; }
        public string AgencyType { get; set; }
        public string TaxId { get; set; }
        public int? ClientLocationId { get; set; }
        public DateTime? ActivationDate { get; set; }
        public string BusinessName { get; set; }
        public string Status { get; set; }
        public string VaultId { get; set; }
        public string VaultKey { get; set; }
        public string ReferralUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Type { get; set; }
        public string ProspectUuid { get; set; }
        public bool? Unsubscribe { get; set; }
        public bool? IsBounce { get; set; }
        public DateTime? BounceDate { get; set; }
        public DateTime? UnsubscribeDate { get; set; }
        public int? BounceMailId { get; set; }
        public int? UnsubscribeMailId { get; set; }
    }
}
