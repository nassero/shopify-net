using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Orders
{
    public class ClientDetail
    {
        public string AcceptLanguage { get; set; }
        public string BrowserHeight { get; set; }
        public string BrowserIp { get; set; }
        public string BrowserWidth { get; set; }
        public string SessionHash { get; set; }
        public string UserAgent { get; set; }
    }
}
