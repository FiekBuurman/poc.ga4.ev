using System.Collections.Generic;
using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
	internal class BaseECommerce
	{
		[JsonProperty("items")]
		public List<Item> Items { get; set; }
	}
}