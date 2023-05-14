using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EvvinfoMappingState
    {
        public int Id { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string EvvcompatibleInfo { get; set; }
        public string DocumentUrl { get; set; }
        public int? ReferralCompanyEvvinfoId { get; set; }
    }
}
