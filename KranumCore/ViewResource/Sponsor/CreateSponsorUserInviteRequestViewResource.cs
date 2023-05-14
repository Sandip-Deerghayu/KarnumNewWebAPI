using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Sponsor
{
    public class CreateSponsorUserInviteRequestViewResource
    {
        public string SponsoredClientUUID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string About { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(75)]
        public string State { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

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

        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Designation { get; set; }
        [StringLength(500)]
        public string Profile { get; set; }

        public List<IFormFile> LogoImage { get; set; }
    }
}
