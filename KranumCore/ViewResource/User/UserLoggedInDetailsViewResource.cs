using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserLoggedInDetailsViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime LoggedInDateTime { get; set; }
    }
}
