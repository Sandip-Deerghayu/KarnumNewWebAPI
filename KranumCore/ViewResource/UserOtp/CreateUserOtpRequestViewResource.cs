using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.UserOtp
{
    public class CreateUserOtpRequestViewResource
    {
       public string EmailOrNum { get; set; }
        public string LoginType { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
