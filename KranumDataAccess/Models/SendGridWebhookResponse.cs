using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class SendGridWebhookResponse
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string ResponseJson { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string EmailId { get; set; }
        public string Url { get; set; }
        public string Event { get; set; }
        public int? MailInteractionId { get; set; }
        public string Type { get; set; }
    }
}
