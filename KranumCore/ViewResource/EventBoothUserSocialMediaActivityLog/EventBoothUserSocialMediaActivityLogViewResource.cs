using KranumCore.ViewResource.EventChatAgent;
using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothUserSocialMediaActivityLog
{
    public class EventBoothUserSocialMediaActivityLogViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventBoothId { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string SocialMedia { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
