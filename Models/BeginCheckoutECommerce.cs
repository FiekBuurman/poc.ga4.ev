using System.Collections.Generic;
using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
    internal class BeginCheckoutECommerce
    {
		[JsonProperty("currency")] 
		public string Currency { get; set; }

		[JsonProperty("value")] 
		public decimal Value { get; set; }

		[JsonProperty("coupon")] 
		public string Coupon { get; set; }

		[JsonProperty("items")]
		public List<Items> Items { get; set; }
    }
}
