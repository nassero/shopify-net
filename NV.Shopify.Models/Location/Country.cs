using System.Collections.Generic;

namespace NV.Shopify.Models.Location
{
    public class Country : ShopifyModel
    {
	    public string Code { get; set; }
	    public string Name { get; set; }
	    public IList<Province> Provinces { get; set; }
	    public float Tax { get; set; }
    }
}
