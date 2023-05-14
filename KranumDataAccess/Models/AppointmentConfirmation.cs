using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AppointmentConfirmation
    {
        public int ConfirmId { get; set; }
        public int? AppId { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public DateTime? ConfirmedOn { get; set; }
        public string ConfirmedBy { get; set; }
    }
}
