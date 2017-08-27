using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Products
{
    public class CustomCollection : PrimaryShopifyModel
    {
	    public string BodyHtml { get; set; }
	    public string Handle { get; set; }
	    public Image Image { get; set; }
	    public IList<Metafield> Metafields { get; set; }
	    public bool Published { get; set; }
		public DateTime? PublishedAt { get; set; }
	    public string PublishedScope { get; set; }
	    public string SortOrder { get; set; }
	    public string TemplateSuffix { get; set; }
	    public string Title { get; set; }
    }
}
