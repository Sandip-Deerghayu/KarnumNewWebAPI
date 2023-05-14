using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBoothUserBookAppointmentActivityLog
{
    public class CreateEventBoothUserBookAppointmentActivityLogRequestViewResource
    {
        [Required]
        public string EventBoothUUID { get; set; }
        [Required]
        public string UserUUID { get; set; }
    }
}
