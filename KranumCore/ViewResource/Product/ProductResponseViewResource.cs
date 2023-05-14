using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Product
{
    public class ProductResponseViewResource
    {
        public string Uuid { get; set; }
        public string ClientUUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public string BuyNowUrl { get; set; }
        public List<TagsViewResource> ProductTags { get; set; }
    }
}
