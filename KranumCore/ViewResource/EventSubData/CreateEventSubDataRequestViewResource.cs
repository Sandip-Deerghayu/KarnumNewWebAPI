using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.EventSubData
{
    public class CreateEventSubDataRequestViewResource
    {
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
        public bool Register { get; set; }
        public bool Interested { get; set; }
        public bool SaveDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
