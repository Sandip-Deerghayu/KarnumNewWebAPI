using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AppointmentActivity
    {
        public int ActivityId { get; set; }
        public int? AppointmentId { get; set; }
        public string ActivityName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
