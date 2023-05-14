using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.User
{
    public class UpdateUserResponseViewResource
    {
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }
        public string AvatarImageUuid { get; set; }
    }
}
