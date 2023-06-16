using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class RemoveFromCartEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypes.RemoveFromCart;

		[JsonProperty("ecommerce")]
		public RemoveFromCartECommerce ECommerce { get; set; }
    }
}
