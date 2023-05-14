using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientImportantInformation
    {
        public int CareClientInformationId { get; set; }
        public string CaregiverPreferance { get; set; }
        public string CaregiverNotes { get; set; }
        public string ExternalCaseManager { get; set; }
        public string InternalCaseManager { get; set; }
        public string PayerGroup { get; set; }
        public string ReferralBy { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
        public string CareClientUuid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Marketer { get; set; }
        public string Scheduler { get; set; }
    }
}
