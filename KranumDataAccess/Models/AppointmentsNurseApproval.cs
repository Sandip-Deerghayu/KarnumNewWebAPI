using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class AppointmentsNurseApproval
    {
        public string NurseUuid { get; set; }
        public long? AppointmentId { get; set; }
        public string NurseSignatureUrl { get; set; }
        public DateTime? SignatureDateTime { get; set; }
        public int Id { get; set; }
    }
}
