using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AssessorPayrollTerms
    {
        public int Id { get; set; }
        public int? CallTypeId { get; set; }
        public int? ManagementPayrollId { get; set; }
        public decimal? PayRate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string AssessorUuid { get; set; }
        public string Status { get; set; }
    }
}
