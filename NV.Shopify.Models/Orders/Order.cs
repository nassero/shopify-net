using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NV.Shopify.Models.Customers;
using NV.Shopify.Models.Location;

namespace NV.Shopify.Models.Orders
{
    public class Order : PrimaryShopifyModel
    {
	    public long AppId { get; set; }
	    public IList<Address> BillingAddress { get; set; }
	    public string BrowserIp { get; set; }
	    public bool BuyerAcceptsMarketing { get; set; }
	    public string CancelReason { get; set; }
        public DateTime? CancelledAt { get; set; }
        public string CartToken { get; set; }
        public IList<ClientDetail> ClientDetails { get; set; }
        public DateTime? ClosedAt { get; set; }
        public string Currency { get; set; }
        public IList<Customer> Customer { get; set; }
        public string CustomerLocale { get; set; }
        public IList<DiscountCode> DiscountCodes { get; set; }
        public string Email { get; set; }
        public string FinancialStatus { get; set; }
        public IList<Fulfillment.Fulfillment> Fulfillments { get; set; }
        public string FulfillmentStatus { get; set; }
        public string Tags { get; set; }
        public string Gateway { get; set; }
        public string LandingSite { get; set; }
        public IList<LineItem> LineItems { get; set; }
        public long LocationId { get; set; }
        public string Name { get; set; }
        public IList<Attribute> NoteAttributes { get; set; }
        public long Number { get; set; }
        public long OrderNumber { get; set; }
        public IList<PaymentDetail> PaymentDetails { get; set; }
        public IList<string> PaymentGatewayNames { get; set; }
        public string Phone { get; set; }
        public DateTime? ProcessedAt { get; set; }
        public string ProcessingMethod { get; set; }
        public string ReferringSite { get; set; }
        public IList<Refund> Refunds { get; set; }
        public IList<Address> ShippingAddress { get; set; }
        public IList<ShippingLine> ShippingLines { get; set; }
        public string SourceName { get; set; }
        public float SubtotalPrice { get; set; }
        public IList<TaxLine> TaxLines { get; set; }
        public bool TaxesIncluded { get; set; }
        public string Token { get; set; }
        public string TotalDiscounts { get; set; }
        public string TotalLineItemsPrice { get; set; }
        public string TotalPrice { get; set; }
        public string TotalTax { get; set; }
        public int TotalWeight { get; set; }
        public long UserId { get; set; }
        public string OrderStatusUrl { get; set; }
    }
}
