using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDiagnosis
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string Changes { get; set; }
        public string AnyChanges { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdetedOn { get; set; }
        public string UpdetedBy { get; set; }
    }
}
