using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.KranumDataMapping
{
    public class KranumDataMappingResponseViewResource
    {
        public string EventUUID { get; set; }
        public string EventTitle { get; set; }
        public DateTime EventStartDatetime { get; set; }

        public List<AttendedUser> AttendedUsers { get; set; }

    }
}
