using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.OnlineStore
{
    public class Comment : PrimaryShopifyModel
    {
	    public long ArticleId { get; set; }
	    public string Author { get; set; }
	    public long BlogId { get; set; }
	    public string Body { get; set; }
	    public string BodyHtml { get; set; }
	    public string Email { get; set; }
	    public string Ip { get; set; }
	    public DateTime? PublishedAt { get; set; }
	    public string Status { get; set; }
	    public string UserAgent { get; set; }
    }
}
