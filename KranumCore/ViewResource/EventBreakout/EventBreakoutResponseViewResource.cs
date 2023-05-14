using KranumCore.ViewResource.EventBreakoutHost;
using KranumCore.ViewResource.Track;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.EventBreakout
{
    public class EventBreakoutResponseViewResource
    {
        public string Uuid { get; set; }
        public string EventUUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public string StartDate { get; set; }
        public string StartTime { get; set; }

        public string EndDate { get; set; }
        public string EndTime { get; set; }

        public string Duration { get; set; }

        public string MeetingUrl { get; set; }
        public string ZoomMeetingId { get; set; }
        public string ZoomMeetingPassword { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public List<string> EventBreakoutHosts { get; set; }

        public List<EventBreakoutHostsResponseViewResource> EventBreakoutHosts { get; set; }
    }
}
