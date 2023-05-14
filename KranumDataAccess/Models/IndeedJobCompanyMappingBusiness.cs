using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class IndeedJobCompanyMappingBusiness
    {
        public int Id { get; set; }
        public string Json { get; set; }
        public string BusinessName { get; set; }
        public string Uuid { get; set; }
        public int? Score { get; set; }
        public string IndeedCompName { get; set; }
        public string State { get; set; }
    }
}
