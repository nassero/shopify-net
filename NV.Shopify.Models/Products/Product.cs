using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Products
{
    public class Product : PrimaryShopifyModel
    {
        public string BodyHtml { get; set; }
        public string Handle { get; set; }
        public IList<Image> Images { get; set; }
        public IList<Option> Options { get; set; }
        public string ProductType { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string PublishedScope { get; set; }
        public string Tags { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
        public string MetafieldsGlobalTitleTag { get; set; }
        public IList<Variant> Variants { get; set; }
        public string Vendor { get; set; }
    }
}
