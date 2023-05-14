using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.EventBreakout
{
    public class CreateEventBreakoutRequestViewResource
    {
        public string EventUUID { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public string StartDate { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndDate { get; set; }
        [Required]
        public string EndTime { get; set; }

        [StringLength(200)]
        public string Duration { get; set; }
        public string MeetingUrl { get; set; }

        [StringLength(50)]
        public string ZoomMeetingId { get; set; }
        public string ZoomMeetingPassword { get; set; }
        public int? CreatedBy { get; set; }
        public List<string> EventBreakoutHosts { get; set; }
    }
}
