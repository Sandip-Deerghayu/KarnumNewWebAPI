using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothUserActivityLog
{
    public class CreateEventBoothUserActivityLogRequestViewResource
    {
        [Required]
        public string EventBoothUUID { get; set; }
        [Required]
        public string Remarks { get; set; }
        [Required]

        public string UserUUID { get; set; }
    }
}
