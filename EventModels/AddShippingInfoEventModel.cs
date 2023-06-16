using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class AddShippingInfoEventModel
    {
		[JsonProperty("event")] 
		public string Event = EventTypeValues.AddShippingInfo;

		[JsonProperty("ecommerce")] 
		public AddShippingInfoECommmerce ECommerce { get; set; }
    }
}
