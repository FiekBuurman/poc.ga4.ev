using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
    internal class ViewCartECommerce : BaseECommerce
    {
		[JsonProperty("currency")] 
		public string Currency { get; set; }

		[JsonProperty("value")] 
		public decimal Value { get; set; }
	}
}
