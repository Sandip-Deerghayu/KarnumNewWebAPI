using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class DossierRequest
    {
        public int Id { get; set; }
        public string RequestBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string ResponseBy { get; set; }
        public DateTime? ResponseDate { get; set; }
        public bool? IsResponsed { get; set; }
        public string DossierUrl { get; set; }
        public string BusinessName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string MailBody { get; set; }
        public string MailSubject { get; set; }
    }
}
