using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Analytics.PlayerVideo
{
    public class PlayerVideoUserDetailsResponseViewResource
    {
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public int TotalRecords { get; set; }

        public List<PlayerVideoUserDetailsViewResource> PlayerVideoUserDetailsViewResource { get; set; }
    }
}
