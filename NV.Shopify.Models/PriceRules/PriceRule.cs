using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.PriceRules
{
    public class PriceRule : PrimaryShopifyModel
    {
        public string Title { get; set; }
        public string TargetType { get; set; }
        public string TargetSelection { get; set; }
        public string AllocationMethod { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public bool OncePerCustomer { get; set; }
        public int UsageLimit { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public IList<long> EntitledProductIds { get; set; }
        public IList<long> EntitledVariantIds { get; set; }
        public IList<long> EntitledCollectionIds { get; set; }
        public IList<long> EntitledCountryIds { get; set; }
        public GreaterThanRange PrerequisiteSubtotalRange { get; set; }
        public LessThanRange PrerequisiteShippingPriceRange { get; set; }
        public IList<long> PrerequisiteSavedSearchIds { get; set; }
    }
}
