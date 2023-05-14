using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserViewResource
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }

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

        public string State { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string BusinessName { get; set; }
        [StringLength(100)]
        public string Designation { get; set; }
        [StringLength(500)]
        public string About { get; set; }
        [StringLength(255)]
        public string AvatarImageUuid { get; set; }
        public bool? IsValid { get; set; }
        public bool IsLogin { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? LiabilityDisclaimerAccepted { get; set; }
        public bool? PrivacyPolicyAccepted { get; set; }
        public bool? IsPasswordReset { get; set; }
        public string EmailVerificationCode { get; set; }

        public string UserName { get; set; }
        public string SignupByEmailOrPhone { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ClientId { get; set; }

    }
}
