using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AgencyMilesRateWithCallType
    {
        public int Id { get; set; }
        public decimal? MilesRate { get; set; }
        public int? ClientLocationId { get; set; }
        public int? CallTypeId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Status { get; set; }
        public decimal? PayableMilesRate { get; set; }
        public string IsMilesRatePayable { get; set; }
        public string IsMilesRateBillable { get; set; }
        public string IsExpensesBillable { get; set; }
        public string IsExpensesPayable { get; set; }
    }
}
