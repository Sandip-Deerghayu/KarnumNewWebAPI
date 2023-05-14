using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Category
{
    public class CreateCategoryRequestViewResource
    {
        /*public int Id { get; set; }
        public string Uuid { get; set; }*/

        [Required]
        [StringLength(500)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [StringLength(100)]
        public string Color { get; set; }
        public List<IFormFile> CategoryImageUUID { get; set; }

    }
}