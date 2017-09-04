using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class PaymentDetail
    {
        public string AvsResultCode { get; set; }
        public string CreditCardBin { get; set; }
        public string CvvResultCode { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardCompany { get; set; }
    }
}
