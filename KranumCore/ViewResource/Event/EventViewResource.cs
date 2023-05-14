using KranumCore.ViewResource.Client;
using KranumCore.ViewResource.EventBooth;
using KranumCore.ViewResource.EventChatAgent;
using KranumCore.ViewResource.Track;
using KranumDataAccess.Model;
using KranumDataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Event
{
    public class EventViewResource
    {
        public int Id { get; set; }
        public string ClientUUId { get; set; }
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
        public string ActualStartDate { get; set; }
        public string ActualStartTime { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime? ActualStartDateTime { get; set; }

        [StringLength(50)]
        public string Duration { get; set; }

        public int? EventResourceVideoId { get; set; }
        public string EventResourceVideoThumbnailUuid { get; set; }
        public string EventResourceCardThumbnailUuid { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual ICollection<TrackViewResource> Track { get; set; }
        public virtual ICollection<ClientNamesViewResource> ClientNames { get; set; }
        public virtual ICollection<EventBoothResponseViewResource> EventBooth { get; set; }
        public List<CreateEventChatAgentViewResource> EventChatAgent { get; set; }
        public string EventType { get; set; }
        public string MeetingUrl { get; set; }
        public string Timezone { get; set; }
        public bool? IsClosedEvent { get; set; }

        [StringLength(100)]
        public string EventCategory { get; set; }
    }
}
