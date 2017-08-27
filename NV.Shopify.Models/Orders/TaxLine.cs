using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders
{
    public class TaxLine
    {
	    public string Price { get; set; }
	    public float Rate { get; set; }
	    public string Title { get; set; }
    }
}
