using System.Collections.Generic;

namespace NV.Shopify.Models.Orders.Fulfillment
{
    public class Fulfillment : PrimaryShopifyModel
    {
	    public IList<LineItem> LineItems { get; set; }
	    public bool NotifyCustomer { get; set; }
	    public long OrderId { get; set; }
	    public IList<Receipt> Receipts { get; set; }
	    public string Status { get; set; }
	    public string TrackingCompany { get; set; }
	    public IList<string> TrackingNumbers { get; set; }
	    public IList<string> TrackingUrls { get; set; }
	    public string VariantInventoryManagement { get; set; }
    }
}
