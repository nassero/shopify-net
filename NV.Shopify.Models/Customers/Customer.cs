using System.Collections.Generic;
using NV.Shopify.Models.Location;

namespace NV.Shopify.Models.Customers
{
    public class Customer : PrimaryShopifyModel
    {
	    public bool AcceptsMarketing { get; set; }
	    public IList<Address> Addresses { get; set; }
	    public IList<Address> DefaultAddresses { get; set; }
		public string FirstName { get; set; }
	    public string LastName { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Note { get; set; }
	    public int OrdersCount { get; set; }
	    public string State { get; set; }
	    public string TotalSpent { get; set; }
	    public string Tags { get; set; }
		public IList<Metafield> Metafields { get; set; }
	    public string MultipassIdentifier { get; set; }
	    public long LastOrderId { get; set; }
	    public string LastOrderName { get; set; }
	    public bool TaxExempt { get; set; }
	    public bool VerifiedEmail { get; set; }
	}
}
