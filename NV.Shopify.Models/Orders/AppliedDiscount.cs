using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders
{
    public class AppliedDiscount
    {
	    public string Title { get; set; }
	    public string Description { get; set; }
	    public string Value { get; set; }
	    public string ValueType { get; set; }
	    public string Amount { get; set; }
    }
}
