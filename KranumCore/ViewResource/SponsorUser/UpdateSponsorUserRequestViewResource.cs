using KranumCore.ViewResource.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class UpdateSponsorUserRequestViewResource
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

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Designation { get; set; }
        [StringLength(500)]
        public string About { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public List<IFormFile> AvatarImage { get; set; }
    }
}
