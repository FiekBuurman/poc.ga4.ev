using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class ViewItemEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypeValues.ViewItem;

		[JsonProperty("ecommerce")]
		public ViewItemECommerce ECommerce { get; set; }
    }
}
