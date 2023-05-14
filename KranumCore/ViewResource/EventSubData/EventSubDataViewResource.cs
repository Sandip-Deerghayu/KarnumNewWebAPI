using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventSubData
{
    public class EventSubDataViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string EventUuid { get; set; }
        public string UserUuid { get; set; }
        public bool Register { get; set; }
        public bool Interested { get; set; }
        public bool SaveDate { get; set; }
        public DateTime? CreatedDate { get; set; }      
    }
}
