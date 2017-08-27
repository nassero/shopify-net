using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models
{
    public class Event : PrimaryShopifyModel
    {
	    public string Arguments { get; set; }
	    public string Body { get; set; }
	    public string Description { get; set; }
	    public string Path { get; set; }
	    public string Message { get; set; }
	    public long SubjectId { get; set; }
	    public string SubjectType { get; set; }
	    public string Verb { get; set; }
    }
}
