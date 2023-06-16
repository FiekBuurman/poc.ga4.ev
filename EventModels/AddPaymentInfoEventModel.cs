using Newtonsoft.Json;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.EventModels
{
	internal class AddPaymentInfoEventModel
	{
		[JsonProperty("event")] 
		public string Event = EventTypes.AddPaymentInfo;

		[JsonProperty("ecommerce")] 
		public AddPaymentInfoECommerce ECommerce { get; set; }
    }
}