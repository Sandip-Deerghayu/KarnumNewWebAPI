using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.BroadcastMessage
{
    public class BroadcastMessageViewResource
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Uuid { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
