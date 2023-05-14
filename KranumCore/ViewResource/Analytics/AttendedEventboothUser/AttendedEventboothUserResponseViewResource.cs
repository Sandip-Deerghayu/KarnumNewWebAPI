using System.Collections.Generic;

namespace KranumCore.ViewResource.Analytics.AttendedEventboothUser
{
    public class AttendedEventboothUserResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<AttendedEventboothUserViewResource> AttendedUsers { get; set; }

    }
}
