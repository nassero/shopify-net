using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class RefundLineItem : ShopifyModel
    {
        public LineItem LineItem { get; set; }
        public long LineItemId { get; set; }
        public int Quantity { get; set; }
    }
}
