using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.User
{
    public class LoginResponseViewResource
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientUUID { get; set; }
        public string UUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string BusinessName { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsValid { get; set; }
        public string EventUUID { get; set; }
        public string JwtToken { get; set; }
        public string About { get; set; }
        public string Designation { get; set; }
        public bool? LiabilityDisclaimerAccepted { get; set; }
        public bool? PrivacyPolicyAccepted { get; set; }
        public bool? IsPasswordReset { get; set; }
        public List<string> Roles { get; set; }
        public bool EventHasAgenda { get; set; }
        public bool EventHasSessions { get; set; }
        public bool EventHasGallery { get; set; }
        public bool EventHasExhibits { get; set; }
        public bool EventHasBreakouts { get; set; }
        public bool? IsCaryfyEvent { get; set; }
        public bool? IsClosedEvent { get; set; }
        public bool HasResources { get; set; }
        public string MeetingUrl { get; set; }

        public string UserName { get; set; }
        public string SignupByEmailOrPhone { get; set; }

        public string UserOtp { get; set; }

    }
}
