using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class SendGridMailReply
    {
        public string Data { get; set; }
        public int Id { get; set; }
        public string FromEmail { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ToEmail { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public string Attachments { get; set; }
        public string JsonList { get; set; }
        public string Html { get; set; }
    }
}
