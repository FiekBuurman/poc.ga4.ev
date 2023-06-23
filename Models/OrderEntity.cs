using System.Collections.Generic;
using System.Reflection.Emit;

namespace poc.ga4.ev.Models
{
	internal class OrderEntity
	{
		// TODO this is gonna be the EV OrderEntity

		public string Number { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal DeliveryCost { get; set; }

		public List<OrderItemEntity> OrderItems => new()
		{
			new OrderItemEntity
			{
				OrderItemId = 123,
				ProductName = "product123",
				Price = 1.23m
			},
			new OrderItemEntity
			{
				OrderItemId = 456,
				ProductName = "product456",
				Price = 4.56m
			}
		};

		public CouponEntity CouponEntity { get; set; }
		public CustomerEntity CustomerEntity { get; set; }

		public string  DeliveryMethod { get; set; }
		public string PaymentMethod { get; set; }
	}

	internal class CustomerEntity
	{
		public string LastName { get; set; } = "Marti-Orbak";
		public string Address { get; set; } = "Hollewatering 3b";
	}

	internal class CouponEntity
	{
		public string CouponName { get; set; } = "Zomerkorting";
	}

	internal class OrderItemEntity
	{
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}
