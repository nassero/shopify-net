using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NV.Shopify.Models.Customers;
using NV.Shopify.Models.Location;

namespace NV.Shopify.Models.Orders
{
    public class AbandonedCheckout : PrimaryShopifyModel
    {
	    public string AbandonedCheckoutUrl { get; set; }
	    public Address BillingAddress { get; set; }
	    public bool BuyerAcceptsMarketing { get; set; }
	    public string CancelReason { get; set; }
	    public string CartToken { get; set; }
	    public DateTime? ClosedAt { get; set; }
	    public DateTime? CompletedAt { get; set; }
	    public string Currency { get; set; }
	    public Customer Customer { get; set; }
	    public IList<DiscountCode> DiscountCodes { get; set; }
	    public string Email { get; set; }
	    public string Gateway { get; set; }
	    public string LandingSite { get; set; }
	    public IList<LineItem> LineItems { get; set; }
	    public string Note { get; set; }
	    public string ReferringSite { get; set; }
	    public IList<Address> ShippingAddress { get; set; }
	    public IList<ShippingLine> ShippingLines { get; set; }
	    public string SourceName { get; set; }
	    public string SubtotalPrice { get; set; }
	    public IList<TaxLine> TaxLines { get; set; }
	    public bool TaxesIncluded { get; set; }
	    public string Token { get; set; }
	    public string TotalDiscounts { get; set; }
	    public string TotalLineItemsPrice { get; set; }
	    public string TotalPrice { get; set; }
	    public string TotalTax { get; set; }
	    public int TotalWeight { get; set; }
    }
}
