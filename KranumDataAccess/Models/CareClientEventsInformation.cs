using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientEventsInformation
    {
        public int Id { get; set; }
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string HasClientFallenRecently { get; set; }
        public string FallenDate { get; set; }
        public string ReasonForFall { get; set; }
        public string DoesClientHaveHistoryOfFalls { get; set; }
        public string FallRisk { get; set; }
        public string HasClientHadAnyRecentHospitalizations { get; set; }
        public string HospitalizationDate { get; set; }
        public string LengthOfStayOfHospitalization { get; set; }
        public string ReasonForHospitalization { get; set; }
        public string AnyNewMedicationsOrDiagnosesNotReflectedOnLists { get; set; }
        public string NewMedicationDetails { get; set; }
        public string HasClientHadAnyRecentMedicationChanges { get; set; }
        public DateTime? DateOfMedicationChanges { get; set; }
        public DateTime? DateOfAppointment { get; set; }
        public string PhysicianName { get; set; }
        public string Speciality { get; set; }
        public string ReasonForAppointment { get; set; }
        public string AnyChangesInLastAppointment { get; set; }
        public string DescribeTheChange { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
