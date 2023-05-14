using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BusinessIndeedJobData
    {
        public long Id { get; set; }
        public string BusinessUuid { get; set; }
        public string CompanyName { get; set; }
        public string IndeedRating { get; set; }
        public string TotalReviews { get; set; }
        public string AgencyAboutUs { get; set; }
        public string HeadquartersAddress { get; set; }
        public string NumberOfEmployees { get; set; }
        public string Revenue { get; set; }
        public string WebSiteAddress { get; set; }
        public string FacebookAddress { get; set; }
        public string TwitterAddress { get; set; }
        public string State { get; set; }
        public string JobLocation { get; set; }
        public string JobTitle { get; set; }
        public string JobPostedDate { get; set; }
        public string NumberOfCompanyReviews { get; set; }
        public string JobDescription { get; set; }
    }
}
