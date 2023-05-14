using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class CreateSessionPollRequestViewResource
    {
        public CreateSessionPollRequestViewResource()
        {
            PollOptions = new List<string>();
        }

        public string UUID { get; set; }
        public string PollQuestion { get; set; }
        public List<string> PollOptions { get; set; }
        public DateTime PollTime { get; set; }
    }
}
