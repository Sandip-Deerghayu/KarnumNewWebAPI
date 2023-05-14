using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothUserSocialMediaActivityLog
{
    public class CreateEventBoothUserSocialMediaActivityLogRequestViewResource
    {
        [Required]
        public string EventUUID { get; set; }
        [Required]
        public string EventBoothUUID { get; set; }
        [Required]
        public string UserUUID { get; set; }
        [Required]
        public string SocialMedia { get; set; }
    }
}
