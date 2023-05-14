using KranumCore.ViewResource.Role;
using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.User
{
    public class UserRoleViewResource
    {
        //public int UserId { get; set; }
        //public int RoleId { get; set; }

        //public RoleViewResource Role { get; set; }

        //public UserViewResource User { get; set; }

        public int Id { get; set; }
        public string UUID { get; set; }
        public string RoleName { get; set; }
    }
}
