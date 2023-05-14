using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.RegisterEvent
{
    public class RegisterEventViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string BusinessName { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
