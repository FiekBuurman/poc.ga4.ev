﻿using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
    internal class AddShippingInfoECommmerce : BaseECommerce
    {
		[JsonProperty("currency")] 
		public string Currency { get; set; }

		[JsonProperty("value")] 
		public decimal Value { get; set; }

		[JsonProperty("coupon")] 
		public string Coupon { get; set; }

		[JsonProperty("shipping_tier")] 
		public string ShippingTier { get; set; }

		[JsonProperty("shipping")] 
		public decimal Shipping { get; set; }
	}
}
