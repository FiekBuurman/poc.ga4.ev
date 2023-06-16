using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
    internal class Customer
    {
		[JsonProperty("customer_mail")]
		public string CustomerMail { get; set; }

		[JsonProperty("customer_phone")]
		public string CustomerPhone { get; set; }

		[JsonProperty("customer_first_name")]
		public string CustomerFirstName { get; set; }

		[JsonProperty("customer_last_name")]
		public string CustomerLastName { get; set; }

		[JsonProperty("customer_address")]
		public string CustomerAddress { get; set; }

		[JsonProperty("customer_city")]
		public string CustomerCity { get; set; }

		[JsonProperty("customer_region")]
		public string CustomerRegion { get; set; }

		[JsonProperty("customer_postal_code")]
		public string CustomerPostalCode { get; set; }

		[JsonProperty("customer_country")]
		public string CustomerCountry { get; set; }
    }
}
