using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Products
{
    public class Image : PrimaryShopifyModel
    {
        public int? Position { get; set; }
        public long? ProductId { get; set; }
        public IList<long> VariantIds { get; set; }
        public string Src { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
