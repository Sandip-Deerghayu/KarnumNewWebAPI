using KranumCore.ViewResource.EventChatAgent;
using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothEnquiry
{
    public class EventBoothEnquiryViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventBoothId { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string EnquiryText { get; set; }
        public DateTime EnquiryDate { get; set; }

    }
}
