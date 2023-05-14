using System;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.SponsorUser
{
    public class UpdateSponsorUserResponseViewResource
    {
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }
        public string AvatarImageUuid { get; set; }
    }
}
