using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class CreateAgencyBusinessRegistrationRequestViewResource
    {
        public string mobileNumber { get; set; }
        public int id { get; set; }
        public bool agency { get; set; }
        public string emailId { get; set; }

        public AgenciesDetails agenciesDetails { get; set; }
    }
}
