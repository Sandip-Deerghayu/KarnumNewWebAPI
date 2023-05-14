using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class CreateUserResponseViewResource
    {
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }
        public string AvatarImageUuid { get; set; }
    }
}
