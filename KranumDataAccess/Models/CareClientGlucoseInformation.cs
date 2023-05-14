using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientGlucoseInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string ClientDiabetic { get; set; }
        public string DiabetesType { get; set; }
        public string CurrentGlucoseReading { get; set; }
        public string Refused { get; set; }
        public string CreateAlertWhenBloodSugarSys { get; set; }
        public string CreateAlertWhenBloodSugarDia { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string GlucoseMonitoringSchedule { get; set; }
        public string SplitShift { get; set; }
    }
}
