using KranumCore.ViewResource.Track;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.EventBreakout
{
    public class EventBreakoutViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Duration { get; set; }

        public string MeetingUrl { get; set; }
        public string ZoomMeetingId { get; set; }
        public string ZoomMeetingPassword { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
