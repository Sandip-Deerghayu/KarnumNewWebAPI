using KranumCore.ViewResource.Resource;
using System;
using System.Collections.Generic;

namespace KranumCore.ViewResource.Event
{
    public class EventGalleryWithResourceResponseViewResource
    {
        public string UUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MeetingUrl { get; set; }
        public List<ResourceResponse> ResourceResponse { get; set; }
    }
}
