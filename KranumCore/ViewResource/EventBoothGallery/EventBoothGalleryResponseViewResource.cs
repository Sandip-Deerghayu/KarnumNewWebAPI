using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.EventBoothGallery
{
    public class EventBoothGalleryResponseViewResource
    {
        public string EventBoothGalleryUUID { get; set; }
        public string ResourceUUID { get; set; }
        public string VideoURL { get; set; }
        public string ResourceTitle { get; set; }
        public string ResourceDescription { get; set; }
        public string ResourceType { get; set; }
        public string BuyNowUrl { get; set; }
    }
}
