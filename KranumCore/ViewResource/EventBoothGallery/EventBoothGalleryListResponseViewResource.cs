using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventBoothGallery
{
    public class EventBoothGalleryListResponseViewResource
    {
        public EventBoothGalleryListResponseViewResource()
        {
            EventBoothGalleryResources = new List<EventBoothGalleryResponseViewResource>();
        }
        public string EventUUID { get; set; }
        public string EventBoothUUID { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string EventBoothTitle { get; set; }
        public string EventBoothDescription { get; set; }

        public List<EventBoothGalleryResponseViewResource> EventBoothGalleryResources { get; set; }
    }
}
