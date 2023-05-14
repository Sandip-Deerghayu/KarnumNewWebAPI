using KranumCore.ViewResource.Resource;
using System;
using System.Collections.Generic;

namespace KranumCore.ViewResource.EventGallery
{
    public class EventGalleryResponseViewResource
    {
        public EventGalleryResponseViewResource()
        {
            //EventGalleryResources = new List<EventGalleryResourceViewResource>();
        }
        public string Uuid { get; set; }
        public string EventUUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MeetingUrl { get; set; }
        public List<string> ResourceUUID { get; set; }
        //public List<EventGalleryResourceViewResource> EventGalleryResources { get; set; }
    }
}
