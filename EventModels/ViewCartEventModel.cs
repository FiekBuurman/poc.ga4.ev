using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class ViewCartEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypes.ViewCart;

		[JsonProperty("ecommerce")]
		public ViewCartECommerce ECommerce { get; set; }
    }
}
