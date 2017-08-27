using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models.Location
{
	public class Province : ShopifyModel
	{
		public string Code { get; set; }
		public long CountryId { get; set; }
		public float Tax { get; set; }
		public string TaxName { get; set; }
		public string TaxType { get; set; }
		public float TaxPercentage { get; set; }
	}
}