using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class EventBreakoutsLiveUpdateResponseViewResource
    {
        public string BreakoutTitle { get; set; }
        public string BreakoutDescription { get; set; }
        public DateTime BreakoutStartDateTime { get; set; }
        public DateTime BreakoutEndDateTime { get; set; }
    }
}
