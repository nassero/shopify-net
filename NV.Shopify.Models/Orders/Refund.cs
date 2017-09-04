using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class Refund : PrimaryShopifyModel
    {
        public DateTime? ProcessedAt { get; set; }
        public string Note { get; set; }
        public IList<RefundLineItem> RefundLineItems { get; set; }
        public bool Restock { get; set; }
        public IList<Transaction> Transactions { get; set; }
        public long UserId { get; set; }
    }
}
