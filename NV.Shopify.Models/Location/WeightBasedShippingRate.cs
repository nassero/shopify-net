using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Location
{
    public class WeightBasedShippingRate : ShopifyModel
    {
        public float WeightLow { get; set; }
        public float WeightHigh { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public long ShippingZoneId { get; set; }
    }
}
