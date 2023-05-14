using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Client
{
    public class ClientSponsorInviteViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string CompanyName { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
