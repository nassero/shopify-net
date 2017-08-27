using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Orders
{
    public class LineItem
    {
	    public bool Custom { get; set; }
	    public int FulfillmentQuantity { get; set; }
	    public string FulfillmentService { get; set; }
	    public int Grams { get; set; }
	    public string Price { get; set; }
	    public long ProductId { get; set; }
	    public int Quantity { get; set; }
	    public bool RequiresShipping { get; set; }
	    public string Sku { get; set; }
	    public string Title { get; set; }
	    public long VariantId { get; set; }
	    public string VariantTitle { get; set; }
	    public string Vendor { get; set; }
	    public string Name { get; set; }
	    public bool GiftCard { get; set; }
		public IList<Attribute> Properties { get; set; }
		public bool Taxable { get; set; }
		public IList<TaxLine> TaxLines { get; set; }
		public IList<AppliedDiscount> AppliedDiscounts { get; set; }
	}
}
