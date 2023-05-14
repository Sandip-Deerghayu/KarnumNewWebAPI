using KranumCore.ViewResource.BroadcastMessage;
using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class EventLiveUpdateResponseViewResource
    {
        public DateTime CurrentDateTime { get; set; }
        public List<EventSessionsLiveUpdateResponseViewResource> EventSessionLiveUpdates { get; set; }
        public List<EventBreakoutsLiveUpdateResponseViewResource> EventBreakoutLiveUpdates { get; set; }
        public List<string> BroadcastMessages { get; set; }
        public bool IsMainSessionLive { get; set; }
        public bool IsEventLive { get; set; }
        public bool IsEventBreakoutLive { get; set; }

    }
}
