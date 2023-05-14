using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Client
{
    public class SignupClientRequestViewResource
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(75)]
        public string Country { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string EmailId { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
