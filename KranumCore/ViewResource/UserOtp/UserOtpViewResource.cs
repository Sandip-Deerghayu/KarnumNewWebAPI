using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserOtp
{

    public class UserOtpViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string EmailOrNum { get; set; }
        public string LoginType { get; set; }
        public string Otp { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
