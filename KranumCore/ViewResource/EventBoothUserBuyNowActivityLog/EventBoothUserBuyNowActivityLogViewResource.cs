using System;

namespace KranumCore.ViewResource.EventBoothUserBuyNowActivityLog
{
    public class EventBoothUserBuyNowActivityLogViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventBoothId { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
