using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.OnlineStore
{
    public class Blog : PrimaryShopifyModel
    {
	    public string Commentable { get; set; }
	    public string Feedburner { get; set; }
	    public string FeedburnerLocation { get; set; }
	    public string Handle { get; set; }
	    public IList<Metafield> Metafields { get; set; }
	    public string Tags { get; set; }
	    public string TemplateSuffix { get; set; }
	    public string Title { get; set; }
    }
}
