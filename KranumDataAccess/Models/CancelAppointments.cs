using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CancelAppointments
    {
        public int Id { get; set; }
        public int? AppointmentId { get; set; }
        public int? ShiftId { get; set; }
        public string CancelBy { get; set; }
        public string CreatedBy { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
