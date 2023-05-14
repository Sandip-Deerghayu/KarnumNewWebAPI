using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CallType
    {
        public int CallTypeId { get; set; }
        public int? ClientLocationId { get; set; }
        public string CallTypeCode { get; set; }
        public string CallTypeDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? QuickBookId { get; set; }
        public string SageEarningCode { get; set; }
        public string CallTypeStatus { get; set; }
    }
}
