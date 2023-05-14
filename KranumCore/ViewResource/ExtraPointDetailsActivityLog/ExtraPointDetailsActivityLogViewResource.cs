using System;

namespace KranumCore.ViewResource.ExtraPointDetailsActivityLog
{
    public class ExtraPointDetailsActivityLogViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Remarks { get; set; }
        public string PointCode { get; set; }
        public int ClientId { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public int Point { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
