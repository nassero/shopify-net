using System;
using System.Collections.Generic;
using System.Text;
using NV.Shopify.Models.Settings;

namespace NV.Shopify.Models.OnlineStore
{
    public class Page : PrimaryShopifyModel
    {
        public string Author { get; set; }
        public string BodyHtml { get; set; }
        public string Handle { get; set; }
        public IList<Metafield> Metafields { get; set; }
        public DateTime? PublishedAt { get; set; }
        public long ShopId { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
    }
}
