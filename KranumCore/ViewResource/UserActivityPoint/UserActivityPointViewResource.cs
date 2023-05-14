using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserActivityPoint
{
    public class UserActivityPointViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string PointCode { get; set; }
        public string ActivityUuid { get; set; }
    }
}
