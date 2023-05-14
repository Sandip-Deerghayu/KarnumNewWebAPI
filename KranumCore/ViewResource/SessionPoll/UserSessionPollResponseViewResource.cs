using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class UserSessionPollResponseViewResource
    {
        public UserSessionPollResponseViewResource()
        {
            UserResponses = new Dictionary<string, int>();
        }
        public string EventTitle { get; set; }
        public string SessionTitle { get; set; }
        public string PollQuestion { get; set; }
        public int TotalResponseCount { get; set; }
        public Dictionary<string, int> UserResponses { get; set; }
    }
}
