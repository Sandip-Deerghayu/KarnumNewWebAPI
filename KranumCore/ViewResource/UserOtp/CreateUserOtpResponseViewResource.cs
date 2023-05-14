using System;

namespace KranumCore.ViewResource.UserOtp
{
    public class CreateUserOtpResponseViewResource
    {

        public string EmailOrNum { get; set; }
        public string LoginType { get; set; }
        public string Otp { get; set; }

        public DateTime DisplayAt { get; set; }

    }
}