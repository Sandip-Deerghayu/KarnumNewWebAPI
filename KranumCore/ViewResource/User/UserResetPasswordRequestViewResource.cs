using KranumCore.ViewResource.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserResetPasswordRequestViewResource
    {
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
