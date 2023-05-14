using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyHolidayRates
    {
        public int AgencyHolidayRatesId { get; set; }
        public int? ClientLocationId { get; set; }
        public decimal? HolidayBillRate { get; set; }
        public decimal? HolidayPayRate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
