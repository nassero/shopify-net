using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders.Fulfillment
{
    public class FulfillmentEvent : PrimaryShopifyModel
    {
	    public long ShopId { get; set; }
	    public long OrderId { get; set; }
	    public long FulfillmentId { get; set; }
	    public string Status { get; set; }
	    public long HappenedAt { get; set; }
	    public string Message { get; set; }
	    public string City { get; set; }
	    public string Province { get; set; }
	    public string Zip { get; set; }
	    public string Country { get; set; }
	    public string Address1 { get; set; }
	    public float Latitude { get; set; }
	    public float Longitude { get; set; }
    }
}
