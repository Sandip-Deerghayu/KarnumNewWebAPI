using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.PlayerVideo
{
    public class PlayerVideoUserDetailsViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string EmailId { get; set; }
        public string ResourceTitle { get; set; }
        public decimal? TotalDuration { get; set; }
        public string TimeStamp { get; set; }
        public decimal? WatchDuration { get; set; }
    }
}
