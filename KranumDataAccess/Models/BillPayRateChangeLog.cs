using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class BillPayRateChangeLog
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public decimal? PreviousBillRate { get; set; }
        public decimal? CurrentBillRate { get; set; }
        public string ChangeBy { get; set; }
        public DateTime? ChangeTime { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CallTypeId { get; set; }
        public int? RateId { get; set; }
    }
}
