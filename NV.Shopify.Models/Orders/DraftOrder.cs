using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NV.Shopify.Models.Location;

namespace NV.Shopify.Models.Orders
{
    public class DraftOrder : PrimaryShopifyModel
    {
	    public long OrderId { get; set; }
	    public string Name { get; set; }
	    public Customers.Customer Customer { get; set; }
	    public IList<Address> ShippingAddresses { get; set; }
	    public IList<Address> BillingAddresses { get; set; }
	    public string Note { get; set; }
	    public IList<Attribute> NoteAttributes { get; set; }
	    public string Email { get; set; }
	    public string Currency { get; set; }
	    public DateTime? InvoiceSentAt { get; set; }
	    public string InvoiceUrl { get; set; }
	    public IList<LineItem> LineItems { get; set; }
	    public IList<ShippingLine> ShippingLines { get; set; }
	    public string Tags { get; set; }
	    public bool TaxesExempt { get; set; }
	    public IList<TaxLine> TaxLines { get; set; }
	    public IList<AppliedDiscount> AppliedDiscounts { get; set; }
	    public bool TaxesIncluded { get; set; }
	    public string TotalTax { get; set; }
	    public float SubtotalPrice { get; set; }
	    public string TotalPrice { get; set; }
	    public DateTime? CompletedAt { get; set; }
		public string Status { get; set; }
    }
}
