using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Location
{
    public class PriceBasedShippingRate : ShopifyModel
    {
        public string Name { get; set; }
        public string MinOrderSubtotal { get; set; }
        public string Price { get; set; }
        public string MaxOrderSubtotal { get; set; }
        public long ShippingZoneId { get; set; }
    }
}
