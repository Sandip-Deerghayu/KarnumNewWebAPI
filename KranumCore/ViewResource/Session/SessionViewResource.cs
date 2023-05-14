using KranumCore.ViewResource.Track;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Session
{
    public class SessionViewResource
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int TrackId { get; set; }
        public int? SessionResourceVideoId { get; set; }
        public string SessionResourceVideoThumbnailUuid { get; set; }
        public string Uuid { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }

        public string EndDate { get; set; }
        public string EndTime { get; set; }

        public bool? isActive { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public bool? EnableAttendeeMic { get; set; }
        public bool? EnableAttendeeCamera { get; set; }

        public bool? IsMain { get; set; }
        public bool? ShowLikeDislike { get; set; }
        public bool? ShowDemo { get; set; }
        public bool? LiveSession { get; set; }
        public string LiveUrl { get; set; }

        public string MeetingUrl { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public string MeetingPassword { get; set; }

        public string ActionType { get; set; }

        public string TimeZone { get; set; }

        public string DownladResource { get; set; }

    }
}
