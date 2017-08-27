using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.OnlineStore
{
    public class Asset : PrimaryShopifyModel
    {
	    public string Attachment { get; set; }
	    public string ContentType { get; set; }
	    public string Key { get; set; }
	    public string PublicUrl { get; set; }
	    public int Size { get; set; }
	    public string SourceKey { get; set; }
	    public string Src { get; set; }
	    public long ThemeId { get; set; }
	    public string Value { get; set; }
    }
}
