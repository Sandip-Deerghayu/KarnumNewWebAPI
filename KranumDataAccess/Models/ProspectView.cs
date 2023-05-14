using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ProspectView
    {
        public string Address { get; set; }
        public string AddressLine { get; set; }
        public string AutoClock { get; set; }
        public string BusinessName { get; set; }
        public string City { get; set; }
        public string ClientLocation { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string EmailId { get; set; }
        public string FanCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string Uuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string ServiceType { get; set; }
        public string Stage { get; set; }
    }
}
