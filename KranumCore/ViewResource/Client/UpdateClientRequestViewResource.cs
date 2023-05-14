using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Client
{
    public class UpdateClientRequestViewResource
    {
        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(500)]
        public string About { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(75)]
        public string State { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        [StringLength(75)]
        public string Country { get; set; }
        [StringLength(255)]
        public string LogoResourceUuid { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }

        public int? ModifiedBy { get; set; }

        public string InitialSetUp { get; set; }
        public List<IFormFile> LogoImage { get; set; }

    }
}
