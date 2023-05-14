using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KranumCore.ViewResource.AgencyInorm
{
    public class AgencyUserLoginRequestViewResource
    {



        [Required]
        [StringLength(100)]
        public string emailId { get; set; }

        [StringLength(100)]
        public string password { get; set; }

    }
}
