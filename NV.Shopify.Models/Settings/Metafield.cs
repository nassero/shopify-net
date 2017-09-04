namespace NV.Shopify.Models.Settings
{
    public class Metafield : PrimaryShopifyModel
    {
	    public string Description { get; set; }
	    public string Key { get; set; }
	    public string Namespace { get; set; }
	    public long OwnerId { get; set; }
	    public string OwnerResource { get; set; }
	    public int Value { get; set; }
	    public string ValueType { get; set; }
    }
}
