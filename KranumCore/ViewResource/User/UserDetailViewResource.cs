using KranumCore.ViewResource.Role;
using KranumCore.ViewResource.UserRole;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserDetailViewResource
    {
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessName { get; set; }
        public string Designation { get; set; }
        public string About { get; set; }
        public string AvatarImageUuid { get; set; }

        public bool? IsValid { get; set; }
        public int Id { get; set; }
        public List<UserRoleViewResource> UserRole { get; set; }

        //public List<RoleViewResource> Role { get; set; }
    }
}
