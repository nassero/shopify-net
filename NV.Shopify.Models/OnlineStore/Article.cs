using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.OnlineStore
{
    public class Article : PrimaryShopifyModel
    {
	    public string Author { get; set; }
	    public long BlogId { get; set; }
	    public string BodyHtml { get; set; }
	    public string Handle { get; set; }
	    public Image Image { get; set; }
	    public IList<Metafield> Metafields { get; set; }
	    public bool Published { get; set; }
	    public DateTime? PublishedAt { get; set; }
	    public string SummaryHtml { get; set; }
	    public string Tags { get; set; }
	    public string TemplateSuffix { get; set; }
	    public string Title { get; set; }
	    public long UserId { get; set; }
    }
}
