using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class CreateSessionPollUserRequestViewResource
    {
        public string EventUUID { get; set; }
        public string SessionUUID { get; set; }
        public string PollUUID { get; set; }
        public string PollOptionUUID { get; set; }
        public string UserUUID { get; set; }
    }
}