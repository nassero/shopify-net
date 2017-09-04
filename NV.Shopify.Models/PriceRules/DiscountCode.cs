using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.PriceRules
{
    public class DiscountCode : PrimaryShopifyModel
    {
        public long PriceRuleId { get; set; }
        public string Code { get; set; }
        public int UsageCount { get; set; }
    }
}
