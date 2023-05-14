using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserActivityPoint
{
    public class UserActivityPointListViewResource
    {
        public string Uuid { get; set; }
        public string EventUUID { get; set; }
        public string EventName { get; set; }
        public string UserUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PointCode { get; set; }
        public string PointText { get; set; }
        public int? PointValue { get; set; }
    }

    public class UserActivityPointResponseViewResource
    {
        public int TotalRecords { get; set; }
        public int Position { get; set; }
        public List<UserActivityPointListViewResource> Points { get; set; }
    }
}
