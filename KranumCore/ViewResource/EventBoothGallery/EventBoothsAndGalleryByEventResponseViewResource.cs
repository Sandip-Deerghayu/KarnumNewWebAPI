using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventBoothGallery
{
    public class EventBoothsAndGalleryByEventResponseViewResource
    {
        public EventBoothsAndGalleryByEventResponseViewResource()
        {
            EventBooths = new List<EventBooths>();
        }
        public List<EventBooths> EventBooths { get; set; }
    }

    public class EventBooths
    {
        public EventBooths()
        {
            EventBoothGalleryResources = new List<EventBoothGalleryResources>();
        }
        public string EventBoothUUID { get; set; }
        public string EventBoothTitle { get; set; }
        public string ClientUUID { get; set; }
        public List<EventBoothGalleryResources> EventBoothGalleryResources { get; set; }
    }

    public class EventBoothGalleryResources
    {
        public string EventBoothGalleryUUID { get; set; }
        public string ResourceUUID { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceType { get; set; }
    }


}
