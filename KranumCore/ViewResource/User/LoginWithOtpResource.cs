using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.User
{
    public class LoginWithOtpResource
    {
        [Required]
        public string Email { get; set; }

        public string UserOtp { get; set; }
        public string UserType { get; set; }
    }
}
