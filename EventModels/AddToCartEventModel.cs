using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class AddToCartEventModel
	{
		[JsonProperty("event")] 
		public string Event = EventTypes.AddToCart;

		[JsonProperty("ecommerce")] 
		public AddToCartECommerce ECommerce { get; set; }
    }
}
