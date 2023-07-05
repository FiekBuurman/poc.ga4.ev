using System.Collections.Generic;
using System.Linq;
using poc.ga4.ev.interfaces;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal class ECommerceFactory : IECommerceFactory
	{
		private const string Currency = "EURO";

		public T CreateECommerce<T>(OrderEntity orderEntity) where T : BaseECommerce, new()
		{
			return CreateBaseECommerce<T>(orderEntity);
		}
		
		public ViewCartECommerce CreateViewCartECommerce(OrderEntity orderEntity)
		{
			var viewCartECommerce = CreateBaseECommerce<ViewCartECommerce>(orderEntity);

			viewCartECommerce.Currency = Currency;
			viewCartECommerce.Value = orderEntity.TotalPrice;

			return viewCartECommerce;
		}

		public BeginCheckoutECommerce CreateBeginCheckoutECommerce(OrderEntity orderEntity)
		{
			var beginCheckoutECommerce = CreateBaseECommerce<BeginCheckoutECommerce>(orderEntity);

			beginCheckoutECommerce.Currency = Currency;
			beginCheckoutECommerce.Value = orderEntity.TotalPrice;
			beginCheckoutECommerce.Coupon = orderEntity.CouponEntity.CouponName;

			return beginCheckoutECommerce;
		}

		public AddShippingInfoECommmerce CreateAddShippingInfoECommerce(OrderEntity orderEntity)
		{
			var addShippingInfoECommerce = CreateBaseECommerce<AddShippingInfoECommmerce>(orderEntity);

			addShippingInfoECommerce.Currency = Currency;
			addShippingInfoECommerce.Value = orderEntity.TotalPrice;
			addShippingInfoECommerce.Coupon = orderEntity.CouponEntity.CouponName;
			addShippingInfoECommerce.ShippingTier = orderEntity.DeliveryMethod;
			addShippingInfoECommerce.Shipping = orderEntity.DeliveryCost;

			return addShippingInfoECommerce;
		}
		
		public AddPaymentInfoECommerce CreateAddPaymentInfoECommerce(OrderEntity orderEntity)
		{
			var addPaymentInfoECommerce = CreateBaseECommerce<AddPaymentInfoECommerce>(orderEntity);

			addPaymentInfoECommerce.Currency = Currency;
			addPaymentInfoECommerce.Value = orderEntity.TotalPrice;
			addPaymentInfoECommerce.Coupon = orderEntity.CouponEntity.CouponName;
			addPaymentInfoECommerce.ShippingTier = orderEntity.DeliveryMethod;
			addPaymentInfoECommerce.Shipping = orderEntity.DeliveryCost;
			addPaymentInfoECommerce.PaymentType = orderEntity.PaymentMethod;

			SetCustomer(addPaymentInfoECommerce, orderEntity.CustomerEntity);

			return addPaymentInfoECommerce;
		}

		public PurchaseECommerce CreatePurchaseECommerce(OrderEntity orderEntity)
		{
			var purchaseECommerce = CreateBaseECommerce<PurchaseECommerce>(orderEntity);

			purchaseECommerce.TransactionId = orderEntity.Number;
			purchaseECommerce.Value = orderEntity.TotalPrice;
			purchaseECommerce.Tax = 0;
			purchaseECommerce.Shipping = orderEntity.DeliveryCost;
			purchaseECommerce.Currency = Currency;
			purchaseECommerce.Coupon = orderEntity.CouponEntity.CouponName;
			purchaseECommerce.ShippingTier = orderEntity.DeliveryMethod;
			purchaseECommerce.Shipping = orderEntity.DeliveryCost;
            purchaseECommerce.PaymentType = orderEntity.PaymentMethod;

			SetCustomer(purchaseECommerce, orderEntity.CustomerEntity);

			return purchaseECommerce;
		}

		private static T CreateBaseECommerce<T>(OrderEntity orderEntity) where T : BaseECommerce, new()
		{
			var eCommerce = new T
			{
				Items = GetItems(orderEntity.OrderItems)
			};

			return eCommerce;
		}

        private static void SetCustomer(CustomerECommerce customerECommerce, CustomerEntity customerEntity)
		{
			customerECommerce.CustomerMail = string.Empty;
            customerECommerce.CustomerPhone = string.Empty;
            customerECommerce.CustomerFirstName = string.Empty;
			customerECommerce.CustomerLastName = customerEntity.LastName;
			customerECommerce.CustomerAddress = customerEntity.Address;
            customerECommerce.CustomerCity = string.Empty;
            customerECommerce.CustomerRegion = string.Empty;
            customerECommerce.CustomerPostalCode = string.Empty;
            customerECommerce.CustomerCountry = string.Empty;
		}
		
        private static List<Item> GetItems(IEnumerable<OrderItemEntity> orderItemEntities)
		{
			return orderItemEntities.Select(Convert).ToList();
		}

		private static Item Convert(OrderItemEntity orderItem)
		{
			return new Item
			{
				ItemId = orderItem.OrderItemId.ToString(),
				ItemName = orderItem.ProductName,
				Discount = 0,
				Index = 0,
				Price = orderItem.Price,
				Quantity = orderItem.Quantity
			};
		}
	}
}