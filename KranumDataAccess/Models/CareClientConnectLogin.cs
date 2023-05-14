using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace KranumDataAccess.Models
{
    public partial class CareClientConnectLogin
    {
        public string EmailId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string DeviceRegistrationId { get; set; }
        public DateTime? LastLogin { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Uuid { get; set; }
        public string UserStatus { get; set; }
        public string DeviceType { get; set; }
        public string IsVerified { get; set; }
        public string IsMobileVerified { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Id { get; set; }
        public string ImgUrl { get; set; }
    }
}
