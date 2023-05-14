using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Product
{
    public class ProductViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string BuyNowUrl { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public virtual ICollection<ProductTagsViewResource> ProductTags { get; set; }
    }
}
