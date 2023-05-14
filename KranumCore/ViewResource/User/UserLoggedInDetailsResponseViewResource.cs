using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserLoggedInDetailsResponseViewResource
    {
        public int TotalLoggedInUsers { get; set; }
        public List<UserLoggedInDetailsViewResource> LoggedInUsers { get; set; }
    }
}
