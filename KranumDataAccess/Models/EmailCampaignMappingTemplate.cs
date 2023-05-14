using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EmailCampaignMappingTemplate
    {
        public int Id { get; set; }
        public int? TemplateId { get; set; }
        public string Condition { get; set; }
        public int? EventId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? MailDate { get; set; }
    }
}
