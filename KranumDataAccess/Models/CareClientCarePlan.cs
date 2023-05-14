using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientCarePlan
    {
        public int Id { get; set; }
        public string CarePlanName { get; set; }
        public string CareClientUuid { get; set; }
        public string CreatedBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string CarePlanStatus { get; set; }
    }
}
