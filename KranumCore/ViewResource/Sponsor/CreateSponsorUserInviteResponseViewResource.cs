using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Sponsor
{
    public class CreateSponsorUserInviteResponseViewResource
    {
        public int ClientId { get; set; }
        public string ClientUUID { get; set; }
        public int UserId { get; set; }
        public string UserUUID { get; set; }
    }
}
