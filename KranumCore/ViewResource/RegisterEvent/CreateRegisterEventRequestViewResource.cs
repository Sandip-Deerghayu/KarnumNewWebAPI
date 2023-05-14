using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace KranumCore.ViewResource.RegisterEvent
{
    public class CreateRegisterEventRequestViewResource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string BusinessName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
