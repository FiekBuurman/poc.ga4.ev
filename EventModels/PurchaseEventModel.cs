using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
	internal class PurchaseEventModel
	{
		[JsonProperty("event")] 
		public string Event = EventTypeValues.Purchase;

		[JsonProperty("ecommerce")] 
		public PurchaseECommerce ECommerce { get; set; }
	}
}