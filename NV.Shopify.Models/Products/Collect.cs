using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Products
{
    public class Collect : PrimaryShopifyModel
    {
	    public long CollectionId { get; set; }
	    public bool Featured { get; set; }
	    public int Position { get; set; }
	    public long ProductId { get; set; }
	    public string SortValue { get; set; }
    }
}
