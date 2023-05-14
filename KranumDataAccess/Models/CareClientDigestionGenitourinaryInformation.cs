using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientDigestionGenitourinaryInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string IsRequireCatheter { get; set; }
        public string CatheterType { get; set; }
        public string CareSchedule { get; set; }
        public string AssistLevelForToileting { get; set; }
        public string Toileting { get; set; }
        public string NoCorrespondingSurgery { get; set; }
        public string FirstCorrespondingSurgery { get; set; }
        public string SecondCorrespondingSurgery { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string IsCorrespondingLimitation { get; set; }
    }
}
