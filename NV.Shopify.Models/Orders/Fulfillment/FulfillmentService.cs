using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders.Fulfillment
{
    public class FulfillmentService
    {
	    public string CallbackUrl { get; set; }
	    public string Format { get; set; }
	    public string Handle { get; set; }
	    public bool InventoryManagement { get; set; }
	    public string Name { get; set; }
	    public long? ProviderId { get; set; }
	    public bool RequiresShippingMethod { get; set; }
	    public bool TrackingSupport { get; set; }
    }
}
