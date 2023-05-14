using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserProfile
{
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public List<UserEventInfo> UserEventInfo { get; set; }
        public List<UserEventVideoEngagement> UserVideoWatchedInfo { get; set; }
        public List<UserQuestionsResponse> UserQuestionsResponse { get; set; }
        public List<UserDownloadedResource> UserDownloadedResource { get; set; }
    }
}
