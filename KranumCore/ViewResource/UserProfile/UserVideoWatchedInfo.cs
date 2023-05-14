using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserProfile
{
    public class UserVideoWatchedInfo
    {
        public string EventTitle { get; set; }
        public string VideoTitle { get; set; }
        public decimal? WatchedDuation { get; set; }
        public List<UserVideoEngagement> UserVideoEngagement { get; set; }
    }
}
