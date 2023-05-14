using System.Collections.Generic;

namespace KranumCore.ViewResource.Analytics.AttendedUser
{
    public class AttendedUserResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<AttendedUserViewResource> AttendedUsers { get; set; }

    }
}
