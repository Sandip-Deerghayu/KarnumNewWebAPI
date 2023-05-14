using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserActivityPoint
{
    public class CreateUserActivityPointViewResource
    {
        public string EventUUID { get; set; }
        public string UserUUID { get; set; }
        public string PointCode { get; set; }
        public string ActivityUuid { get; set; }
        public int ExhibitorAsClientId { get; set; }
        public DateTime CreateAt { get; set; }

    }
}