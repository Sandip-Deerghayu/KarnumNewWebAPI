using KranumCore.ViewResource.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UserListingResponseViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public string Designation { get; set; }
        public string AvatarImageUuid { get; set; }
        public string About { get; set; }
        public List<UserRoleMasterViewResource> UserRole { get; set; }

    }
}
