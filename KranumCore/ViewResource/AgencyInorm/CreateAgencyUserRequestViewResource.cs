using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class CreateAgencyUserRequestViewResource
    {


    [Required]
        [StringLength(50)]
        public string firstName { get; set; }

        [Required]
        [StringLength(50)]
        public string lastName { get; set; }


        [Required]
        [StringLength(100)]
        public string emailId { get; set; }

        [Required]
        [StringLength(20)]
        public string mobileNumber { get; set; }

        [StringLength(50)]
        public string countryCode { get; set; }

        [StringLength(200)]
        public string smsHashCode { get; set; }

        [StringLength(100)]
        public string password { get; set; }

    }
}
