using Newtonsoft.Json;
using poc.ga4.ev.Extensions;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
	internal class BaseEventModel
	{
		public BaseEventModel(EventType eventType) 
			=> Event = eventType.EnumMemberValue();

		[JsonProperty("event")] 
		public string Event { get; private set; }
		
		[JsonProperty("ecommerce")]
        public BaseECommerce ECommerce { get; set; }
	}
}