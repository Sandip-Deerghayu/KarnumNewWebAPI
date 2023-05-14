using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Clients
    {
        public int ClientId { get; set; }
        public string BusinessName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public int? CityId { get; set; }
        public string ContactNo { get; set; }
        public string EmailId { get; set; }
        public string Website { get; set; }
        public int? PackageId { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string CogentEmployeeCode { get; set; }
        public bool IsActive { get; set; }
        public string ClientIdentifier { get; set; }
        public string Status { get; set; }
    }
}
