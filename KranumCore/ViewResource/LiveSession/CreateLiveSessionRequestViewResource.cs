using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.LiveSession
{
    public class CreateLiveSessionRequestViewResource
    {
        public string EventUuid { get; set; }
        public string meetingName { get; set; }
        public string SessionUuid { get; set; }
        public string UserUuid { get; set; }
        public bool enableMic { get; set; }
        public bool enableCam { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
