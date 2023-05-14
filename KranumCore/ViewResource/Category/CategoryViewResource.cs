using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Category
{
    public class CategoryViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }

        [Required]
        [StringLength(500)]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [StringLength(100)]
        public string Color { get; set; }
        public string CategoryImageUUID { get; set; }

    }
}