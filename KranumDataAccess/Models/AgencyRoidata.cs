using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyRoidata
    {
        public int Id { get; set; }
        public decimal? Roiamount { get; set; }
        public decimal? TotalRolamount { get; set; }
        public int? TotalClient { get; set; }
        public int? TotalCaregiver { get; set; }
        public int? TotalEmployee { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? ClientLocationId { get; set; }
    }
}
