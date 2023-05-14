using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime? StartAppointmentDate { get; set; }
        public DateTime? EndAppointmentDate { get; set; }
        public string EmployeeUuid { get; set; }
        public string CustomerUuid { get; set; }
        public string CustomerType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string Type { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? FeedbackId { get; set; }
        public string CustomerEmail { get; set; }
        public string ProductType { get; set; }
        public string Category { get; set; }
    }
}
