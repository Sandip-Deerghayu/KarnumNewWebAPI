using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class SessionPollResponseViewResource
    {
        public SessionPollResponseViewResource()
        {
            SessionPollOptions = new List<SessionPollOptionsResponseViewResource>();
        }
        public string UUID { get; set; }
        public int Id { get; set; }
        public string PollQuestion { get; set; }

        public DateTime PollTime { get; set; }
        public List<SessionPollOptionsResponseViewResource> SessionPollOptions { get; set; }
    }
}
