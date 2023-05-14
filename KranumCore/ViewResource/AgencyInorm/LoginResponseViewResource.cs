using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class LoginResponseViewResource
    {
        public int id { get; set; }
        public string emailId { get; set; }
        public string uuid { get; set; }
        public string mobileNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool isAgency { get; set; }
        public int countryCode { get; set; }
        public int otp { get; set; }
        public string token { get; set; }
        public bool isInvitation { get; set; }
        public AgenciesDetails agenciesDetails { get; set; }
        public bool isReminder { get; set; }
        public bool isConnected { get; set; }
        public List<object> agenciesList { get; set; }
        public bool status { get; set; }
    }
    public class AgenciesDetails
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public string mobileNumber { get; set; }
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
