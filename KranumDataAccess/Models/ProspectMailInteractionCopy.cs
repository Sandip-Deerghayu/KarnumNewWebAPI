using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class ProspectMailInteractionCopy
    {
        public int Id { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string SendGridMessageId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string ProspectUuid { get; set; }
        public string FromEmail { get; set; }
        public string ToEmail { get; set; }
    }
}
