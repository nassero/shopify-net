using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.OnlineStore
{
    public class Redirect : ShopifyModel
    {
        public string Path { get; set; }
        public string Target { get; set; }
    }
}
