using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KranumCore.ViewResource.Product
{
    public class CreateProductRequestViewResource
    {
        public string ClientUUID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        [StringLength(255)]
        public string ImageUrl1 { get; set; }
        [StringLength(255)] 
        public string ImageUrl2 { get; set; }
        [StringLength(255)]
        public string ImageUrl3 { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string BuyNowUrl { get; set; }
        public List<int> Tags { get; set; }
    }
}
