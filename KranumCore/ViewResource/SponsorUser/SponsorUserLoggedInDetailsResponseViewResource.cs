using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class SponsorUserLoggedInDetailsResponseViewResource
    {
        public int TotalLoggedInUsers { get; set; }
        public List<SponsorUserLoggedInDetailsViewResource> LoggedInUsers { get; set; }
    }
}
