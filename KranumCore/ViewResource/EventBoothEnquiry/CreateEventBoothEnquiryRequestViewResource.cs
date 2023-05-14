using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothEnquiry
{
    public class CreateEventBoothEnquiryRequestViewResource
    {
        [Required]
        public string EventBoothUUID { get; set; }
        [Required]
        public string UserUUID { get; set; }

        public string EnquiryText { get; set; }
    }
}
