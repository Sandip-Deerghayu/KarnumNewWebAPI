using KranumCore.ViewResource.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UpdateUserRequestViewResource
    {
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailId { get; set; }

        [StringLength(100)]
        public string SecondaryEmailId { get; set; }

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string BusinessName { get; set; }

        [StringLength(100)]
        public string Designation { get; set; }
        [StringLength(500)]
        public string About { get; set; }

        public string EmailVerificationCode { get; set; }

        public bool? IsValid { get; set; }
        public bool IsLogin { get; set; }
        public List<IFormFile> AvatarImage { get; set; }
        public string UserRole { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int ClientId { get; set; }
    }
}
