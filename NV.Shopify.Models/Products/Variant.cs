using System;
using System.Collections.Generic;
using System.Text;
using NV.Shopify.Models.Settings;

namespace NV.Shopify.Models.Products
{
    public class Variant : PrimaryShopifyModel
    {
        public string Barcode { get; set; }
        public string CompareAtPrice { get; set; }
        public string FulfillmentService { get; set; }
        public int Grams { get; set; }
        public long? ImageId { get; set; }
        public float Weight { get; set; }
        public string WeightUnit { get; set; }
        public string InventoryManagement { get; set; }
        public string InventoryPolicy { get; set; }
        public int InventoryQuantity { get; set; }
        public int? OldInventoryQuantity { get; set; }
        public int? InventoryQuantityAdjustment { get; set; }
        public IList<Metafield> Metafield { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public int Position { get; set; }
        public float Price { get; set; }
        public long ProductId { get; set; }
        public bool RequiresShipping { get; set; }
        public string Sku { get; set; }
        public bool Taxable { get; set; }
        public string Title { get; set; }
    }
}
