using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class EventEmailSent
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Uuid { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool? IsMailSend { get; set; }
        public string SendGridId { get; set; }
        public string ToEmail { get; set; }
        public string FromEmail { get; set; }
        public DateTime? SentDate { get; set; }
        public int? EmailCampaignMappingTemplateId { get; set; }
    }
}
