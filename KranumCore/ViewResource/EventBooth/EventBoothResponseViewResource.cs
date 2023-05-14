using KranumCore.ViewResource.Event;
using KranumCore.ViewResource.EventBoothGallery;
using KranumCore.ViewResource.EventChatAgent;
using KranumCore.ViewResource.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBooth
{
    public class EventBoothResponseViewResource
    {
        public EventBoothResponseViewResource()
        {
            Users = new List<UserProfileViewResource>();
            EventBoothGalleryResources = new List<EventBoothGalleryResponseViewResource>();
        }
        public string EventUUID { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }

        public string EventType { get; set; }
        public string ClientUUID { get; set; }
        public string Uuid { get; set; }

        public string SponsoredClientUUID { get; set; }

        public string EventTitle { get; set; }
        public string ClientName { get; set; }
        public string BoothTitle { get; set; }
        public string OfferDetails { get; set; }
        [StringLength(255)]
        public string CarouselScreen1Uuid { get; set; }
        public string CarouselScreen2Uuid { get; set; }
        public string CarouselScreen3Uuid { get; set; }
        public string BoothVideoResourceUuid { get; set; }
        public string BoothVideoResourceUrl { get; set; }
        public string BoothResourceImage1Uuid { get; set; }
        public string BoothResourceImage2Uuid { get; set; }
        public string BoothResourceImage3Uuid { get; set; }
        public string BoothResourceImage4Uuid { get; set; }
        public string Tags { get; set; }
        public string ExternalUrl { get; set; }
        public string MeetingUrl { get; set; }
        public string BoothSponsorUsers { get; set; }
        public int CreatedBy { get; set; }
        public List<UserProfileViewResource> Users { get; set; }
        public List<string> VideoResourceUUIDList { get; set; }
        public List<string> ImageResourceUUIDList { get; set; }

        public List<EventBoothGalleryResponseViewResource> EventBoothGalleryResources { get; set; }
        public bool? IsEventKindMeetingUrl { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string BuynowUrl { get; set; }
        public string BookAppointmentUrl { get; set; }
        public string LogoResourceUuid { get; set; }
    }
}
    