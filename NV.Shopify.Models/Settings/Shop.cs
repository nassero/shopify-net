using System;
using System.Collections.Generic;
using System.Text;

namespace NV.Shopify.Models.Settings
{
    public class Shop : PrimaryShopifyModel
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string CustomerEmail { get; set; }
        public string Currency { get; set; }
        public string Domain { get; set; }
        public string Email { get; set; }
        public string GoogleAppsDomain { get; set; }
        public bool? GoogleAppsLoginEnabled { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string MoneyFormat { get; set; }
        public string MoneyWithCurrencyFormat { get; set; }
        public string WeightUnit { get; set; }
        public string MyshopifyDomain { get; set; }
        public string Name { get; set; }
        public string PlanName { get; set; }
        public bool HasDiscounts { get; set; }
        public bool HasGiftCards { get; set; }
        public string PlanDisplayName { get; set; }
        public bool PasswordEnabled { get; set; }
        public string Phone { get; set; }
        public string PrimaryLocale { get; set; }
        public string Province { get; set; }
        public string ProvinceCode { get; set; }
        public string ShopOwner { get; set; }
        public string Source { get; set; }
        public bool ForceSsl { get; set; }
        public bool? TaxShipping { get; set; }
        public bool? TaxesIncluded { get; set; }
        public bool? CountryTaxes { get; set; }
        public string Timezone { get; set; }
        public string IanaTimezone { get; set; }
        public string Zip { get; set; }
        public bool HasStorefront { get; set; }
        public bool SetupRequired { get; set; }
    }
}
