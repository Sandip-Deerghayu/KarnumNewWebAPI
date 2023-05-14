using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class EventSessionsLiveUpdateResponseViewResource
    {
        public string SessionTitle { get; set; }
        public string SessionDescription { get; set; }
        public DateTime SessionStartDateTime { get; set; }
        public DateTime SessionEndDateTime { get; set; }
        public bool? IsMain { get; set; }
    }
}
