using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Plus
{
    public class GiftCard : PrimaryShopifyModel
    {
	    public long ApiClientId { get; set; }
	    public long UserId { get; set; }
	    public long OrderId { get; set; }
	    public long CustomerId { get; set; }
	    public long LineItemId { get; set; }
	    public float Balance { get; set; }
	    public string Currency { get; set; }
	    public string Code { get; set; }
	    public string LastCharacters { get; set; }
	    public string Note { get; set; }
	    public string TemplateSuffix { get; set; }
	    public DateTime? DisabledAt { get; set; }
	    public DateTime? ExpiresOn { get; set; }
    }
}
