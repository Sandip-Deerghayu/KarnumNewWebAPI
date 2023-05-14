using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothUserBuyNowActivityLog
{
    public class CreateEventBoothUserBuyNowActivityLogRequestViewResource
    {
        [Required]
        public string EventBoothUUID { get; set; }
        [Required]
        public string UserUUID { get; set; }
    }
}
