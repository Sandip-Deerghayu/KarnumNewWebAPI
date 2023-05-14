using System;

namespace KranumCore.ViewResource.EventGallery
{
    public class EventGalleryViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MeetingUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
