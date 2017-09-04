using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Products
{
    public class Rule
    {
        public string Column { get; set; }
        public string Relation { get; set; }
        public string Condition { get; set; }
    }
}
