using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AppointmentsRequest
    {
        public long Id { get; set; }
        public DateTime StartAppointmentDate { get; set; }
        public string AppointmentFor { get; set; }
        public string Duration { get; set; }
        public string Patient { get; set; }
        public string Reason { get; set; }
        public int ClientLocationId { get; set; }
        public bool? IsCancelled { get; set; }
        public bool? IsConfirmed { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string PatientIdentifier { get; set; }
        public int Status { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? EndAppointmentDate { get; set; }
        public string Provider { get; set; }
        public string ApprovedBy { get; set; }
        public string ReasonOfReject { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string CancellationReason { get; set; }
    }
}
