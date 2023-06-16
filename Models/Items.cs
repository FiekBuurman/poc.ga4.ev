using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
	internal class Items
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("affiliation")]
        public string Affiliation { get; set; }

        [JsonProperty("coupon")]
        public string Coupon { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("discount")]
        public decimal Discount { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item_brand")]
        public string ItemBrand { get; set; }

        [JsonProperty("item_category")]
        public string ItemCategory { get; set; }

        [JsonProperty("item_category2")]
        public string ItemCategory2 { get; set; }

        [JsonProperty("item_category3")]
        public string ItemCategory3 { get; set; }

        [JsonProperty("item_category4")]
        public string ItemCategory4 { get; set; }

        [JsonProperty("item_category5")]
        public string ItemCategory5 { get; set; }

        [JsonProperty("item_list_id")]
        public string ItemListId { get; set; }

        [JsonProperty("item_list_name")]
        public string ItemListName { get; set; }

        [JsonProperty("item_variant")]
        public string ItemVariant { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("promotion_id")]
        public string PromotionId { get; set; }

        [JsonProperty("promotion_name")]
        public string PromotionName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}