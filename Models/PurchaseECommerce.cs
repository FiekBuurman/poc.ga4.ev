using Newtonsoft.Json;

namespace poc.ga4.ev.Models
{
	internal class PurchaseECommerce : CustomerECommerce
	{
		[JsonProperty("transaction_id")] 
		public string TransactionId { get; set; }

		[JsonProperty("value")] 
		public decimal Value { get; set; }

		[JsonProperty("tax")] 
		public decimal Tax { get; set; }

		[JsonProperty("shipping")] 
		public decimal Shipping { get; set; }

		[JsonProperty("currency")] 
		public string Currency { get; set; }

		[JsonProperty("coupon")] 
		public string Coupon { get; set; }

		[JsonProperty("shipping_tier")] 
		public string ShippingTier { get; set; } 

		[JsonProperty("payment_type")] 
		public string PaymentType { get; set; }
		
	}
}