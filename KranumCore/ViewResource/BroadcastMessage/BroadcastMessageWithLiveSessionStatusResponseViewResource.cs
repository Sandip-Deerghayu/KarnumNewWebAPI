using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.BroadcastMessage
{
    public class BroadcastMessageWithLiveSessionStatusResponseViewResource
    {
        public BroadcastMessageWithLiveSessionStatusResponseViewResource()
        {
            BroadcastMessages = new List<BroadcastMessageResponseViewResource>();
        }
        public bool IsMainSessionLive { get; set; }
        public List<BroadcastMessageResponseViewResource> BroadcastMessages { get; set; }
    }
}
