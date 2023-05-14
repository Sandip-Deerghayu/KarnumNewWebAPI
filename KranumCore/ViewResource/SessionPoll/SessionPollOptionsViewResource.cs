using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.SessionPoll
{
    public class SessionPollOptionsViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int PollId { get; set; }
        public string PollOption { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
