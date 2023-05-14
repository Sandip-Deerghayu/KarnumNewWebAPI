using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class AgencyBusinessRegistarViewResource
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public string mobileNumber { get; set; }
        public string uuid { get; set; }
        public string companyName { get; set; }
        public string address { get; set; }
        public string addressLine { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string country { get; set; }
        public int userId { get; set; }
        public int agenciesId { get; set; }
    }

    
}
