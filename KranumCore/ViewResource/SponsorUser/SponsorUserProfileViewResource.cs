using KranumCore.ViewResource.Role;
using KranumCore.ViewResource.UserRole;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class SponsorUserProfileViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public string About { get; set; }
        public string AvatarImageUuid { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
    }
}
