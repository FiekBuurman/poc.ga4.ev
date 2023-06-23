using System.Collections.Generic;
using System.Linq;
using poc.ga4.ev.interfaces;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal class ECommerceFactory : IECommerceFactory
	{
		private const string Currency = "EURO";

		public ViewItemListECommerce CreateViewItemListECommerce(OrderEntity orderEntity)
		{
			var viewItemListECommerce = new ViewItemListECommerce();
			SetItems(viewItemListECommerce, orderEntity.OrderItems);
			return viewItemListECommerce;
		}

		public SelectItemECommerce CreateSelectItemECommerce(OrderEntity orderEntity)
		{
			var selectItemECommerce = new SelectItemECommerce();
			SetItems(selectItemECommerce, orderEntity.OrderItems);
			return selectItemECommerce;
		}

		public ViewItemECommerce CreateViewItemECommerce(OrderEntity orderEntity)
		{
			var viewItemECommerce = new ViewItemECommerce();
			SetItems(viewItemECommerce, orderEntity.OrderItems);
			return viewItemECommerce;
		}

		public AddToCartECommerce CreateAddToCartECommerce(OrderEntity orderEntity)
		{
			var addToCartECommerce = new AddToCartECommerce();
			SetItems(addToCartECommerce, orderEntity.OrderItems);
			return addToCartECommerce;
		}

		public RemoveFromCartECommerce CreateRemoveFromCartECommerce(OrderEntity orderEntity)
		{
			var removeFromCartECommerce = new RemoveFromCartECommerce();
			SetItems(removeFromCartECommerce, orderEntity.OrderItems);
			return removeFromCartECommerce;
		}

		public ViewCartECommerce CreateViewCartECommerce(OrderEntity orderEntity)
		{
			var viewCartECommerce = new ViewCartECommerce
			{
				Currency = Currency,
				Value = orderEntity.TotalPrice
            };
			SetItems(viewCartECommerce, orderEntity.OrderItems);
			return viewCartECommerce;
		}

		public BeginCheckoutECommerce CreateBeginCheckoutECommerce(OrderEntity orderEntity)
		{
			var beginCheckoutECommerce = new BeginCheckoutECommerce
			{
				Currency = Currency,
				Value = orderEntity.TotalPrice,
				Coupon = orderEntity.CouponEntity.CouponName
			};
			SetItems(beginCheckoutECommerce, orderEntity.OrderItems);
			return beginCheckoutECommerce;
		}

		public AddShippingInfoECommmerce CreateAddShippingInfoECommerce(OrderEntity orderEntity)
		{
			var addShippingInfoECommerce = new AddShippingInfoECommmerce
			{
				Currency = Currency,
				Value = orderEntity.TotalPrice,
				Coupon = orderEntity.CouponEntity.CouponName,
				ShippingTier = orderEntity.DeliveryMethod,
				Shipping = orderEntity.DeliveryCost,
			};
			
			SetItems(addShippingInfoECommerce, orderEntity.OrderItems);
			return addShippingInfoECommerce;
		}


		public AddPaymentInfoECommerce CreateAddPaymentInfoECommerce(OrderEntity orderEntity)
		{
			var eCommerce = new AddPaymentInfoECommerce
			{
				Currency = Currency,
				Value = orderEntity.TotalPrice,
				Coupon = orderEntity.CouponEntity.CouponName,
				ShippingTier = orderEntity.DeliveryMethod,
				Shipping = orderEntity.DeliveryCost,
				PaymentType = orderEntity.PaymentMethod
			};

			SetCustomer(eCommerce, orderEntity.CustomerEntity);
			SetItems(eCommerce, orderEntity.OrderItems);

			return eCommerce;
		}

		public PurchaseECommerce CreatePurchaseECommerce(OrderEntity orderEntity)
		{
			var purchaseECommerce = new PurchaseECommerce
			{
				TransactionId = orderEntity.Number,
				Value = orderEntity.TotalPrice,
                Tax = 0,
				Shipping = orderEntity.DeliveryCost,
				Currency = Currency,
				Coupon = orderEntity.CouponEntity.CouponName,

				ShippingTier = orderEntity.DeliveryMethod,
				PaymentType = orderEntity.PaymentMethod
            };
			SetCustomer(purchaseECommerce, orderEntity.CustomerEntity);
			SetItems(purchaseECommerce, orderEntity.OrderItems);

			return purchaseECommerce;
		}

		private static void SetItems(BaseECommerce baseECommerce, IEnumerable<OrderItemEntity> orderItemEntities)
		{
			baseECommerce.Items = orderItemEntities.Select(Convert).ToList();
		}

		private static void SetCustomer(CustomerECommerce customerECommerce, CustomerEntity customerEntity)
		{
			customerECommerce.CustomerAddress = customerEntity.Address;
			customerECommerce.CustomerMail = string.Empty;
            customerECommerce.CustomerPhone = string.Empty;
            customerECommerce.CustomerFirstName = string.Empty;
            customerECommerce.CustomerLastName = customerEntity.Address;
			customerECommerce.CustomerAddress = string.Empty;
            customerECommerce.CustomerCity = string.Empty;
            customerECommerce.CustomerRegion = string.Empty;
            customerECommerce.CustomerPostalCode = string.Empty;
            customerECommerce.CustomerCountry = string.Empty;
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
				Quantity = orderItem.Quantity,
			};
		}
	}
}