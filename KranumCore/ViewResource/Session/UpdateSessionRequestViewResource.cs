using KranumCore.ViewResource.SessionPoll;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Session
{
    public class UpdateSessionRequestViewResource
    {
        [Required]
        public string UUID { get; set; }

        [Required]
        public string TrackUUID { get; set; }
        public string SessionResourceVideoUUID { get; set; }
        public string SessionResourceVideoThumbnailUuid { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        //public DateTime StartDateTime { get; set; }
        //public DateTime EndDateTime { get; set; }

        [Required]
        public string StartDate { get; set; }
        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndDate { get; set; }
        [Required]
        public string EndTime { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public bool? EnableAttendeeMic { get; set; }
        public bool? EnableAttendeeCamera { get; set; }

        public bool? IsMain { get; set; }
        public bool? ShowLikeDislike { get; set; }
        public bool? ShowDemo { get; set; }
        public string LiveUrl { get; set; }
        public bool? LiveSession { get; set; }

        public string MeetingUrl { get; set; }
        public string TimeZone { get; set; }
        public int? ModifiedBy { get; set; }
        
        public string DownladResource { get; set; }

        public List<string> SessionSpeakers { get; set; }

        public List<string> DeletedSessionPollUUID { get; set; }
        public List<string> DeletedSessionPollOptionUUIDs { get; set; }
        public List<CreateSessionPollRequestViewResource> SessionPoll { get; set; }
    }
}