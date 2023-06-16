using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class BeginCheckoutEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypeValues.BeginCheckout;

		[JsonProperty("ecommerce")]
		public BeginCheckoutECommerce ECommerce { get; set; }
    }
}
