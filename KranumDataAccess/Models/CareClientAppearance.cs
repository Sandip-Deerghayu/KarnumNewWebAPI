using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientAppearance
    {
        public int Id { get; set; }
        public string CareCientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string ClientGeneralAppearance { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string IsOnOxygen { get; set; }
        public string WeightMonitoringSchedule { get; set; }
        public string WeightMonitorShift { get; set; }
        public string FirstCorrespondingDiagnosis { get; set; }
        public string SecondCorrespondigDiagnosis { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdetedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string OxygenLiters { get; set; }
    }
}
