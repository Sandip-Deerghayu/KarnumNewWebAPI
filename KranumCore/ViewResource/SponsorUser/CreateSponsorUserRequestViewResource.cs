using KranumCore.ViewResource.UserRole;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class CreateSponsorUserRequestViewResource
    {
        public string ClientUUID { get; set; }
        public string ClientUserEmailId { get; set; }
        public string ClientUserFullName { get; set; }

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
        [StringLength(255)]

        public string CreateBySponsorUUID { get; set; }

        public int? CreatedBy { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }

        public List<IFormFile> AvatarImage { get; set; }
    }
}
