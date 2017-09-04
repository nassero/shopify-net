using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Products
{
    public class SmartCollection : PrimaryShopifyModel
    {
        public string BodyHtml { get; set; }
        public string Handle { get; set; }
        public Image Image { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string PublishedScope { get; set; }
        public IList<Rule> Rules { get; set; }
        public bool Disjunctive { get; set; }
        public string SortOrder { get; set; }
        public string TemplateSuffix { get; set; }
        public string Title { get; set; }
    }
}
