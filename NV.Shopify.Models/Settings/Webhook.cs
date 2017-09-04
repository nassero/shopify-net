using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Settings
{
    public class Webhook : PrimaryShopifyModel
    {
        public string Address { get; set; }
        public IList<string> Fields { get; set; }
        public string Format { get; set; }
        public IList<string> MetafieldNamespaces { get; set; }
        public string Topic { get; set; }
    }
}
