using KranumCore.ViewResource.UserRole;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UpdateUserPolicyTermsRequestViewResource
    {
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }

        public bool? LiabilityDisclaimerAccepted { get; set; }
        public bool? PrivacyPolicyAccepted { get; set; }
    }
}
