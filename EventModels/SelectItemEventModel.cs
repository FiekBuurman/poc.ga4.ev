using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
    internal class SelectItemEventModel
    {
		[JsonProperty("event")]
		public string Event = EventTypeValues.SelectItem;

		[JsonProperty("ecommerce")]
		public SelectItemECommerce ECommerce { get; set; }
    }
}
