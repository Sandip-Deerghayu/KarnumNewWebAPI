using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientBloodPressureInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string BpreadingSys { get; set; }
        public string BpreadingDia { get; set; }
        public string Refused { get; set; }
        public string CreateAlertAtBpsys { get; set; }
        public string CreateAlertAtBpdia { get; set; }
        public string BpmonitoringSchedule { get; set; }
        public string SplitShiftMonitoring { get; set; }
        public string NoCorrespondingDxforBp { get; set; }
        public string FirstCorrespondingDxforBp { get; set; }
        public string SecondCorrespondingDxforBp { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string ReadingSpecifics { get; set; }
        public string ArmReadingSpecifics { get; set; }
        public string PositionReadingSpecifics { get; set; }
    }
}
