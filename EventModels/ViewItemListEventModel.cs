using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
	internal class ViewItemListEventModel
	{
		[JsonProperty("event")] 
		public string Event = EventTypeValues.ViewItemList;

		[JsonProperty("ecommerce")] 
		public ViewItemListECommerce ECommerce { get; set; }
	}
}