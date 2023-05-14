using KranumCore.ViewResource.EventChatAgent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBooth
{
    public class UpdateEventBoothRequestViewResource
    {
        [Required]
        public string UUID { get; set; }

        [Required]
        public string ClientUUID { get; set; }
        [Required]
        public string BoothTitle { get; set; }
        public string OfferDetails { get; set; }
        [StringLength(255)]
        public string CarouselScreen1Uuid { get; set; }
        public string CarouselScreen2Uuid { get; set; }
        public string CarouselScreen3Uuid { get; set; }
        public string BoothVideoResourceUuid { get; set; }
        public string BoothResourceImage1Uuid { get; set; }
        public string BoothResourceImage2Uuid { get; set; }
        public string BoothResourceImage3Uuid { get; set; }
        public string BoothResourceImage4Uuid { get; set; }
        //public CreateEventChatAgentViewResource EventChatAgent { get; set; }
        public string Tags { get; set; }
        public string ExternalUrl { get; set; }
        public string MeetingUrl { get; set; }
        public string BoothSponsorUsers { get; set; }
        public int ModifiedBy { get; set; }
        public List<string> VideoResourceUUIDList { get; set; }
        public List<string> ImageResourceUUIDList { get; set; }
        public bool? IsEventKindMeetingUrl { get; set; }
        public string BuynowUrl { get; set; }
        public string BookAppointmentUrl { get; set; }
    }

}
