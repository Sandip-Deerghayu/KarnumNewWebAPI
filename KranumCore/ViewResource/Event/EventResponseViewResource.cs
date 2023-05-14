using KranumCore.ViewResource.Client;
using KranumCore.ViewResource.EventBooth;
using KranumCore.ViewResource.EventBreakout;
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
    public class EventResponseViewResource
    {
        public EventResponseViewResource()
        {
            //EventSponsors = new List<ClientResponseViewResource>();
            //EventPlatinumSponsors = new List<ClientResponseViewResource>();
            //EventSequence = new List<EventSequenceViewResource>();
        }
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? AllDay { get; set; }
        public string Product { get; set; }
        public string ChannelType { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Url { get; set; }
        public string EventKindUuid { get; set; }
        //public string ClientUUID { get; set; }
        //public string Uuid { get; set; }
        //[Required]
        //[StringLength(200)]
        //public string Title { get; set; }
        //[StringLength(200)]
        //public string Description { get; set; }

        //public string StartDate { get; set; }
        //public string StartTime { get; set; }

        //public string ActualStartDate { get; set; }
        //public string ActualStartTime { get; set; }

        //public string EndDate { get; set; }
        //public string EndTime { get; set; }
        //public DateTime StartDateTime { get; set; }
        //public DateTime EndDateTime { get; set; }
        //public DateTime? ActualStartDateTime { get; set; }

        //[StringLength(50)]
        //public string Duration { get; set; }

        //public string EventResourceVideoUUID { get; set; }
        //public string EventResourceVideoURL { get; set; }
        //public string EventResourceVideoThumbnailUuid { get; set; }
        //public string EventResourceCardThumbnailUuid { get; set; }
        //public int? CreatedBy { get; set; }
        //public DateTime? CreatedDate { get; set; }
        //public int? ModifiedBy { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public virtual ICollection<TrackViewResource> Track { get; set; }

        //public virtual ICollection<ClientNamesViewResource> ClientNames { get; set; }

        //public virtual ICollection<ClientResponseViewResource> EventSponsors { get; set; }
        //public virtual ICollection<ClientResponseViewResource> EventPlatinumSponsors { get; set; }
        //public virtual ICollection<ClientNamesViewResource> EventPlatinumSponsorNames { get; set; }

        //public virtual ICollection<EventBoothResponseViewResource> EventBooth { get; set; }

        //public List<EventBreakoutResponseViewResource> EventBreakout { get; set; }
        //public List<EventSequenceViewResource> EventSequence { get; set; }
        //public string EventType { get; set; }
        //public string MeetingUrl { get; set; }
        //public string Timezone { get; set; }
        //public bool? IsClosedEvent { get; set; }
        //public DateTime CurrentUTCDateTime { get; set; }

        //[StringLength(100)]
        //public string EventCategory { get; set; }
    }
}
