using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Client
{
    public class ClientDisplayViewResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

    }
}
