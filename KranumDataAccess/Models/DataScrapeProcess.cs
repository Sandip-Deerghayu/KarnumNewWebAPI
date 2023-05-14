using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class DataScrapeProcess
    {
        public DataScrapeProcess()
        {
            DataScrapAgency = new HashSet<DataScrapAgency>();
        }

        public int Id { get; set; }
        public string SourceName { get; set; }
        public string StateCode { get; set; }
        public int? TotalRecords { get; set; }
        public DateTime ProcessDate { get; set; }

        public virtual ICollection<DataScrapAgency> DataScrapAgency { get; set; }
    }
}
