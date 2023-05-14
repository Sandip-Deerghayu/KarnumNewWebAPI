using KranumCore.ViewResource.SessionPoll;
using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class EventSequenceViewResource
    {
        public EventSequenceViewResource()
        {
            SessionPollResponse = new List<UserSessionPollResponse>();
        }
        public string UUID { get; set; }
        public string Type { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ZoomMeetingId { get; set; }
        public string ZoomMeetingPassword { get; set; }
        public string SessionResourceVideoUUID { get; set; }
        public string SessionResourceVideoURL { get; set; }

        public string SessionResourceVideoThumbnailUuid { get; set; }

        public string DownladResource { get; set; }

        public string TimeZone { get; set; }
        public bool IsLiveSession {get; set;}
        public SessionPollResponseViewResource SessionPoll { get; set; }

        public List<SessionPollResponseViewResource> SessionPollList { get; set; }
        public List<UserSessionPollResponse> SessionPollResponse { get; set; }
    }

    public class UserSessionPollResponse
    {
        public string UUID { get; set; }
        public int PollCount { get; set; }
    }
}
