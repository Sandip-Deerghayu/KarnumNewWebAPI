using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.UserResourceDownloadDetails
{
    public class UserResourceDownloadDetailsViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string EventTitle { get; set; }
        public string EventBoothTitle { get; set; }
        public string ResourceTitle { get; set; }
        public DateTime DownloadedDate { get; set; }
    }
}
