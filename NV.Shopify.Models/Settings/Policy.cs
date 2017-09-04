using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Settings
{
    public class Policy
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
