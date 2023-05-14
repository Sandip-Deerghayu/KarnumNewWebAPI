using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ReferralCompany
    {
        public int ReferralCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PersonOfContact { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string FaxNumber { get; set; }
        public string Address { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string ImageUrl { get; set; }
        public string ReferralCompanyUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Status { get; set; }
        public int? ClientLocationId { get; set; }
    }
}
