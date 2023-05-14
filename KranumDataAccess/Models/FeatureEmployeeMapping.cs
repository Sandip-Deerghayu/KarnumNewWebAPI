using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class FeatureEmployeeMapping
    {
        public int FeatureEmployeeMappingId { get; set; }
        public string EmployeeUuid { get; set; }
        public int? FeatureId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool? Read { get; set; }
        public bool? Write { get; set; }
        public bool? Delete { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
