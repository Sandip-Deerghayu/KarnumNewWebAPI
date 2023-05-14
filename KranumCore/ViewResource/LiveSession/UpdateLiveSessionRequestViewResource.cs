using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.LiveSession
{
    public class UpdateLiveSessionRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
        public string meetingName { get; set; }
        public string SessionUuid { get; set; }
        public string meetingUuid { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
