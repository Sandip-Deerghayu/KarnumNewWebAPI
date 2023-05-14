using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientContactInformationCopy
    {
        public string FirstName { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public string ClientIdentifier { get; set; }
        public string MaritalState { get; set; }
        public string SpouseName { get; set; }
        public string HomePhone { get; set; }
        public string OtherPhone { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string LastName { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        public string Uuid { get; set; }
        public string TokenId { get; set; }
        public string Status { get; set; }
        public string Office { get; set; }
        public string IsVeteran { get; set; }
        public string StartOfCase { get; set; }
        public string Languages { get; set; }
        public string OfficeNotes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string PasswordSalt { get; set; }
        public string ClientLocationId { get; set; }
        public string CreatedBy { get; set; }
        public int? ConnectStatus { get; set; }
        public string PhysicianName { get; set; }
        public string ImgUrl { get; set; }
        public string VaultKey { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Ssn { get; set; }
        public string CareDeliveryAddress { get; set; }
        public string ReferralUuid { get; set; }
        public string ReferralType { get; set; }
        public string PhysicianAddressLine1 { get; set; }
        public string PhysicianAddressLine2 { get; set; }
        public string PhysicianCity { get; set; }
        public string PhysicianZipCode { get; set; }
        public string PhysicianState { get; set; }
        public string PhysicianCountry { get; set; }
        public string PhysicianOfficePhone { get; set; }
        public string PhysicianFax { get; set; }
        public string CareDeliveryAddressLine2 { get; set; }
        public string CareDeliveryCity { get; set; }
        public string CareDeliveryState { get; set; }
        public string CareDeliveryZipCode { get; set; }
        public string CareDeliveryCountry { get; set; }
        public string IsPrimaryAddressAsCareDelivery { get; set; }
        public int? CustomerId { get; set; }
        public int? AgencyLocationId { get; set; }
    }
}
