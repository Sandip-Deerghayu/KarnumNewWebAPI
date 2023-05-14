using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.UserResourceDownloadDetails
{
    public class UserResourceDownloadDetailsResponseViewResource
    {
        public int TotalRecords { get; set; }
        public List<UserResourceDownloadDetailsViewResource> UserResourceDownloadDetails { get; set; }
    }
}
