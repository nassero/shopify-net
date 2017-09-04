using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.OnlineStore
{
    public class Theme : PrimaryShopifyModel
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public bool Previewable { get; set; }
        public bool Processing { get; set; }
    }
}
