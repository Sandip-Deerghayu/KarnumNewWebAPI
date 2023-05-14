using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ImportBusinessData
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string BusinessName { get; set; }
        public string AddressLine1 { get; set; }
        public string WebsiteUrl { get; set; }
        public string EmailId { get; set; }
        public string WebsiteEmail { get; set; }
        public string FbEmail { get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
        public string FbUrl { get; set; }
        public string FbStatusCode { get; set; }
        public string FanCount { get; set; }
        public string FbAddress { get; set; }
        public string FbPhone { get; set; }
        public string LastPostTimestamp { get; set; }
        public string PostalCode { get; set; }
        public string Source { get; set; }
        public string ServiceType { get; set; }
        public string County { get; set; }
        public string MapLocation { get; set; }
        public string Tags { get; set; }
        public string FbPosts { get; set; }
        public DateTime? ImportedDate { get; set; }
        public string Administrator { get; set; }
        public string Hha { get; set; }
        public string Notes { get; set; }
    }
}
