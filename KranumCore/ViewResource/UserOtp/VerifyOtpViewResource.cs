using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.UserOtp
{

    public class VerifyOtpViewResource
    {
       
        public string EmailOrNum { get; set; }
        public string Otp { get; set; }
     
    }
}
