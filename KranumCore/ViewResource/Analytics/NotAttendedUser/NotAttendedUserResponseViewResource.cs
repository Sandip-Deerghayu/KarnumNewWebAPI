using System.Collections.Generic;

namespace KranumCore.ViewResource.Analytics.NotAttendedUser
{
    public class NotAttendedUserResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<NotAttendedUserViewResource> NotAttendedUsers { get; set; }
    }
}
