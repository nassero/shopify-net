using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class OrderRisk : ShopifyModel
    {
        public bool CauseCancel { get; set; }
        public bool Display { get; set; }
        public long OrderId { get; set; }
        public string Message { get; set; }
        public string Recommendation { get; set; }
        public float Score { get; set; }
        public string Source { get; set; }
    }
}
