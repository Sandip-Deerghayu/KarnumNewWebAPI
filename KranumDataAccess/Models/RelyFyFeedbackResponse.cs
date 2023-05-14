using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class RelyFyFeedbackResponse
    {
        public long Id { get; set; }
        public int? FeedbackId { get; set; }
        public string FeedbackBy { get; set; }
        public string Action { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ProductType { get; set; }
        public int? AppointmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
