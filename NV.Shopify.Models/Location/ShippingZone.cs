using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Location
{
    public class ShippingZone : ShopifyModel
    {
        public string Name { get; set; }
        public IList<Country> Countries { get; set; }
        public IList<Province> Provinces { get; set; }
        public IList<WeightBasedShippingRate> WeightBasedShippingRates { get; set; }
        public IList<PriceBasedShippingRate> PriceBasedShippingRates { get; set; }
        public IList<CarrierShippingRateProvider> CarrierShippingRateProviders { get; set; }
    }
}
