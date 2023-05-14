using KranumCore.ViewResource.EventChatAgent;
using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBooth
{
    public class EventBoothViewResource
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int ClientId { get; set; }
        public string Uuid { get; set; }
        public string BoothTitle { get; set; }
        public string OfferDetails { get; set; }
        public int? CarouselScreen1ResourceId { get; set; }
        public int? CarouselScreen2ResourceId { get; set; }
        public int? CarouselScreen3ResourceId { get; set; }
        public int? BoothVideoResourceId { get; set; }
        public int? BoothResourceImage1ResourceId { get; set; }
        public int? BoothResourceImage2ResourceId { get; set; }
        public int? BoothResourceImage3ResourceId { get; set; }
        public int? BoothResourceImage4ResourceId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public string Tags { get; set; }
        public string ExternalUrl { get; set; }
        public string MeetingUrl { get; set; }
        public string BoothSponsorUsers { get; set; }

        public CreateEventChatAgentViewResource EventChatAgent { get; set; }
        public bool? IsEventKindMeetingUrl { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string BuynowUrl { get; set; }
        public string BookAppointmentUrl { get; set; }
    }
}
