using KranumCore.ViewResource.UserProfile;
using System.Collections.Generic;

namespace KranumCore.ViewResource.KranumDataMapping
{
    public class AttendedUser
    {
        public string UserUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string SecondaryEmailId { get; set; }
        public List<UserWatchedVideo> UserWatchedVideo { get; set; }
        public List<UserDownloadResource> UserDownloadedResource { get; set; }
    }
}