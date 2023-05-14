using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyFyFeedbackResponseMappingCall
    {
        public int Id { get; set; }
        public string CallSid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? RelyFyFeedbackResponseId { get; set; }
    }
}
