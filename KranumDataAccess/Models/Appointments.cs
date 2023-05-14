using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Appointments
    {
        public long Id { get; set; }
        public DateTime StartAppointmentDate { get; set; }
        public string AppointmentFor { get; set; }
        public string Duration { get; set; }
        public string Patient { get; set; }
        public string Reason { get; set; }
        public int? ClientLocationId { get; set; }
        public bool? IsCancelled { get; set; }
        public bool? IsConfirmed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string PatientIdentifier { get; set; }
        public int? Status { get; set; }
        public int? ServiceId { get; set; }
        public DateTime EndAppointmentDate { get; set; }
        public string EmployeeId { get; set; }
        public int? EmployeeRequired { get; set; }
        public string Title { get; set; }
        public string CancellationBy { get; set; }
        public DateTime? CancellationDate { get; set; }
        public string CancellationReason { get; set; }
        public int? ShiftId { get; set; }
        public int? CallTypeId { get; set; }
        public string StaffUuid { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? CgAckTime { get; set; }
        public decimal? PayRate { get; set; }
        public decimal? BillRate { get; set; }
        public int? MgmtRatesId { get; set; }
        public int? MgmtPayrollId { get; set; }
        public string PayrollStatus { get; set; }
        public decimal? CaregiverOverTimeHour { get; set; }
        public string ApprovalType { get; set; }
        public string IsFacility { get; set; }
        public long? FacilityShiftId { get; set; }
        public string CaregiverApprovalType { get; set; }
        public string CaregiverApprovalStatus { get; set; }
        public string CaregiverApprovalBy { get; set; }
        public DateTime? CaregiverApprovalTime { get; set; }
        public string CareClientApprovalBy { get; set; }
        public DateTime? CareClientApprovalTime { get; set; }
        public int? CarePlanId { get; set; }
        public string CareNotesForFacilityShift { get; set; }
        public decimal? HolidayBillRate { get; set; }
        public string HolidayPayRate { get; set; }
        public string IsHoliday { get; set; }
        public int? WagesId { get; set; }
        public string FacilityRateType { get; set; }
        public string FacilityTimeType { get; set; }
        public decimal? MilesRate { get; set; }
        public decimal? PayableMilesRate { get; set; }
    }
}
