using System;
using System.Collections.Generic;
using System.Text;

namespace KranumCore.ViewResource.Product
{
    public class ProductTagsViewResource
    {
        public int Id { get; set; }
        public string Uuid { get; set; }
        public int TagId { get; set; }
        public int ProductId { get; set; }
    }
}
