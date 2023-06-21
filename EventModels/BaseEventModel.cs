using Newtonsoft.Json;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.EventModels
{
	internal class BaseEventModel
	{
		[JsonProperty("event")] 
		public string Event { get; set; }

		[JsonProperty("ecommerce")]
        public BaseECommerce ECommerce { get; set; }
	}
}