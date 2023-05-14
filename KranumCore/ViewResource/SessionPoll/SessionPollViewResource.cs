using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class SessionPollViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public int SessionId { get; set; }
        public string PollQuestion { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
