﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
    internal class SelectItemECommerce
    {
		[JsonProperty("items")] 
		public List<Items> Items { get; set; }
    }
}
