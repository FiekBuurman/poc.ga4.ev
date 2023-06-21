using System.Collections.Generic;
using System.Reflection.Emit;

namespace poc.ga4.ev.Models
{
    internal class OrderEntity
    {
        // TODO this is gonna be the EV OrderEntity

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
	}

	internal class OrderItemEntity
	{
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}
