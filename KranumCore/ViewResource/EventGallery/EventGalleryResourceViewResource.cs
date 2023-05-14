using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventGallery
{
    public class EventGalleryResourceViewResource
    {
        public EventGalleryResourceViewResource()
        {
            EventGalleryResourceUserInterestViewResources = new List<EventGalleryResourceUserInterestViewResource>();
        }

        public string UUID { get; set; }
        public string ResourceUUID { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceDescription { get; set; }
        public List<EventGalleryResourceUserInterestViewResource> EventGalleryResourceUserInterestViewResources { get; set; }
    }
}
