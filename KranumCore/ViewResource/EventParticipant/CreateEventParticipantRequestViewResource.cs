using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventParticipant
{
    public class CreateEventParticipantRequestViewResource
    {
        public string UserUUID { get; set; }
        public string EventUUID { get; set; }
    }
}
