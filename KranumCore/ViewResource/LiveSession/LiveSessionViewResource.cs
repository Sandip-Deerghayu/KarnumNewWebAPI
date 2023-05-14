using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.LiveSession
{
    public class LiveSessionViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
        public string meetingName { get; set; }
        public string SessionUuid { get; set; }
        public string meetingUuid { get; set; }
        public DateTime? CreatedDate { get; set; }     
    }
}
