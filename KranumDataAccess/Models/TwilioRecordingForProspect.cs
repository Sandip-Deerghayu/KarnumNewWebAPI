using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class TwilioRecordingForProspect
    {
        public int Id { get; set; }
        public string CallStatus { get; set; }
        public string ApiVersion { get; set; }
        public string Duration { get; set; }
        public string Client { get; set; }
        public string Direction { get; set; }
        public DateTime? CallDate { get; set; }
        public string CallDuration { get; set; }
        public string AccountSid { get; set; }
        public string CallbackSource { get; set; }
        public string ApplicationSid { get; set; }
        public string Caller { get; set; }
        public string CallSid { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string ProspectUuid { get; set; }
    }
}
