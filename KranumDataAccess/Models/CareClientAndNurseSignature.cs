using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientAndNurseSignature
    {
        public string CareClientUuid { get; set; }
        public string NurseUuid { get; set; }
        public string NurseSignatureUrl { get; set; }
        public string ClientSignatureUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Id { get; set; }
        public int? EmployeeAppointmentId { get; set; }
    }
}
