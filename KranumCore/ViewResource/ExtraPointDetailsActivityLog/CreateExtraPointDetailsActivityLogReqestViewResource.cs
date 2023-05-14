using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.ExtraPointDetailsActivityLog
{
    public class CreateExtraPointDetailsActivityLogReqestViewResource
    {
        [Required]
        public string EventUUID { get; set; }
        
        [Required]
        public string Remarks { get; set; }

        [Required]
        public int Point { get; set; }

        [Required]
        public string UserUUID { get; set; }
    }

    public class ExtraPointDetailsActivityLogReqestViewResource
    {
        [Required]
        public string EventUUID { get; set; }
    }
}
