using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserNamesViewResource
    {
        public string Uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
