using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class RemoveFromCartEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypeValues.RemoveFromCart;

		[JsonProperty("ecommerce")]
		public RemoveFromCartECommerce ECommerce { get; set; }
    }
}
