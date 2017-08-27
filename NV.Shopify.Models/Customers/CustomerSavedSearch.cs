using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Customers
{
    public class CustomerSavedSearch : PrimaryShopifyModel
    {
	    public string Name { get; set; }
	    public string Query { get; set; }
    }
}
