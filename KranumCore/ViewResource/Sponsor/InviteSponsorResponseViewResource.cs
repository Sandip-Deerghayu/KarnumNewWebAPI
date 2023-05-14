using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Sponsor
{
    public class InviteSponsorResponseViewResource
    {
        public string ResponseText { get; set; }

        public string SponsoredClientUUID { get; set; }
        public string ClientName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string EmailId { get; set; }
    }
}
