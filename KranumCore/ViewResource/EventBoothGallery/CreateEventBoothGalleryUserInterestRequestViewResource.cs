using System;

namespace KranumCore.ViewResource.EventBoothGallery
{
    public class CreateEventBoothGalleryUserInterestRequestViewResource
    {
        public string UserUUID { get; set; }
        public string EventUUID { get; set; }
        public string EventBoothUUID { get; set; }
        public string EventBoothGallaryResourceUUID { get; set; }
    }
}
