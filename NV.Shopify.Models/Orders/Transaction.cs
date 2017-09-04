using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class Transaction : PrimaryShopifyModel
    {
        public string Amount { get; set; }
        public string Authorization { get; set; }
        public long? DeviceId { get; set; }
        public string Gateway { get; set; }
        public string SourceName { get; set; }
        public IList<PaymentDetail> PaymentDetails { get; set; }
        public string Kind { get; set; }
        public long OrderId { get; set; }
        public Receipt Receipt { get; set; }
        public string ErrorCode { get; set; }
        public string Status { get; set; }
        public bool Test { get; set; }
        public long? UserId { get; set; }
        public string Currency { get; set; }
    }
}
