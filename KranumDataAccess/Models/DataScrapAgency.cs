using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class DataScrapAgency
    {
        public int Id { get; set; }
        public int ProcessId { get; set; }
        public string State { get; set; }
        public string StateUrl { get; set; }
        public string City { get; set; }
        public string CityUrl { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public string Zip { get; set; }
        public string AgencyServices { get; set; }
        public string AgencyTelephone { get; set; }
        public string GoogleCardWebUrl { get; set; }
        public string GoogleCardPhone { get; set; }
        public string GoogleCardMapUrl { get; set; }
        public bool? GoogleCardProcessStatus { get; set; }
        public string GoogleSearchWebUrl { get; set; }
        public string GoogleSearchRatio { get; set; }
        public string GoogleSearchTitleRatio { get; set; }
        public string GoogleSearchLinkRatio { get; set; }
        public bool? GoogleSearchProcessStatus { get; set; }
        public string Fburl { get; set; }
        public bool? FbprocessState { get; set; }
        public string StateCode { get; set; }

        public virtual DataScrapeProcess Process { get; set; }
    }
}
