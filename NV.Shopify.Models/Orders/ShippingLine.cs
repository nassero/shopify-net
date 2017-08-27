using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders
{
    public class ShippingLine
    {
	    public string Code { get; set; }
	    public string Price { get; set; }
	    public string Source { get; set; }
	    public string Title { get; set; }
	    public string Handle { get; set; }
    }
}
