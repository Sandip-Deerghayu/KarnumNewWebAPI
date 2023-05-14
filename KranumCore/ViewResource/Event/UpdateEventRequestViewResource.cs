using KranumCore.ViewResource.EventChatAgent;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Event
{
    public class UpdateEventRequestViewResource
    {
        public string ClientUserEmailId { get; set; }
        public string ClientUserFullName { get; set; }

        [Required]
        public string UUID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }

        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public string ActualStartDate { get; set; }
        public string ActualStartTime { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }
        public string EventResourceVideoUUID { get; set; }
        public string EventResourceVideoThumbnailUuid { get; set; }
        public string EventResourceCardThumbnailUuid { get; set; }
        public int? ModifiedBy { get; set; }
        public List<string> EventSponsorClientUUID { get; set; }
        public List<string> EventPlatinumSponsorClientUUID { get; set; }
        public string MeetingUrl { get; set; }
        public string Timezone { get; set; }
        public bool? IsClosedEvent { get; set; }

        [StringLength(100)]
        public string EventCategory { get; set; }
    }
}
