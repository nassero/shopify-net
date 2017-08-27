using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NV.Shopify.Models
{
	public interface IShopifyModel
	{
		long Id { get; set; }
	}

	public abstract class ShopifyModel : IShopifyModel
	{
		public long Id { get; set; }
    }

	public abstract class PrimaryShopifyModel : ShopifyModel
	{
		public DateTime CreatedAt { get; set; }
		public DateTime? ModifiedAt { get; set; }
	}
}
