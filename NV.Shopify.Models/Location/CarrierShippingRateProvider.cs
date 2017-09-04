using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Location
{
    public class CarrierShippingRateProvider : ShopifyModel
    {
        public long CarrierServiceId { get; set; }
        public string FlatModifier { get; set; }
        public int PercentModifier { get; set; }
        public KeyValuePair<string, string> ServiceFilter { get; set; }
        public long ShippingZoneId { get; set; }
    }
}
