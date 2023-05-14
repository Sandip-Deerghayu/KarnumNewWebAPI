using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.EventBooth
{
    public class ApproveEventBoothRequestViewResource
    {
        public string EventUUID { get; set; }
        public string EventBoothUUID { get; set; }
    }
}
