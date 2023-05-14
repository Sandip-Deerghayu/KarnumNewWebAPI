using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KranumCore.ViewResource.Client
{
    public class CreateClientSponsorInviteRequestViewResource
    {
        public string SponsoredClientUUID { get; set; }

        public string SponsoredClientUserUUID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string EmailId { get; set; }
        [StringLength(100)]
        public string CompanyName { get; set; }
    }
}
