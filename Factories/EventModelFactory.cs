// Ignore Spelling: poc

using System;
using poc.ga4.ev.EventModels;
using poc.ga4.ev.Extensions;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.Factories
{
	internal class EventModelFactory : IEventModelFactory
	{
		private readonly ECommerceFactory _eCommerceFactory = new();

		public BaseEventModel Create(EventType eventType, OrderEntity orderEntity)
		{
			switch (eventType)
			{
				case EventType.ViewItemList:
					return CreateViewItemListEventModel(orderEntity);
				case EventType.SelectItem:
					return CreateSelectItemEventModel(orderEntity);
				case EventType.ViewItem:
					return CreateViewItemEventModel(orderEntity);
				case EventType.AddToCart:
					return CreateAddToCartEventModel(orderEntity);
				case EventType.RemoveFromCart:
					return CreateRemoveFromCartEventModel(orderEntity);
				case EventType.ViewCart:
					return CreateViewCartEventModel(orderEntity);
				case EventType.BeginCheckout:
					return CreateBeginCheckoutEventModel(orderEntity);
				case EventType.AddShippingInfo:
					return CreateAddShippingInfoEventModel(orderEntity);
				case EventType.AddPaymentInfo:
					return CreateAddPaymentInfoEventModel(orderEntity);
				case EventType.Purchase:
					return CreatePurchaseEventModel(orderEntity);
				default:
					throw new ArgumentOutOfRangeException(nameof(eventType), eventType, null);
			}
		}

		private ViewItemListEventModel CreateViewItemListEventModel(OrderEntity orderEntity)
		{
			return new ViewItemListEventModel
			{
				Event = EventType.ViewItemList.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateViewItemListECommerce(orderEntity)
			};
		}

		private SelectItemEventModel CreateSelectItemEventModel(OrderEntity orderEntity)
		{
			return new SelectItemEventModel
			{
				Event = EventType.SelectItem.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateSelectItemECommerce(orderEntity)
			};
		}

		private ViewItemEventModel CreateViewItemEventModel(OrderEntity orderEntity)
		{
			return new ViewItemEventModel
			{
				Event = EventType.ViewItem.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateViewItemECommerce(orderEntity)
			};
		}

		private AddToCartEventModel CreateAddToCartEventModel(OrderEntity orderEntity)
		{
			return new AddToCartEventModel
			{
				Event = EventType.AddToCart.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateAddToCartECommerce(orderEntity)
			};
		}

		private RemoveFromCartEventModel CreateRemoveFromCartEventModel(OrderEntity orderEntity)
		{
			return new RemoveFromCartEventModel
			{
				Event = EventType.RemoveFromCart.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateRemoveFromCartECommerce(orderEntity)
			};
		}

		private ViewCartEventModel CreateViewCartEventModel(OrderEntity orderEntity)
		{
			return new ViewCartEventModel
			{
				Event = EventType.ViewCart.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateViewCartECommerce(orderEntity)
			};
		}

		private BeginCheckoutEventModel CreateBeginCheckoutEventModel(OrderEntity orderEntity)
		{
			return new BeginCheckoutEventModel
			{
				Event = EventType.BeginCheckout.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateBeginCheckoutECommerce(orderEntity)
			};
		}

		private AddShippingInfoEventModel CreateAddShippingInfoEventModel(OrderEntity orderEntity)
		{
			return new AddShippingInfoEventModel
			{
				Event = EventType.AddShippingInfo.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateAddShippingInfoECommerce(orderEntity)
			};
		}

		private AddPaymentInfoEventModel CreateAddPaymentInfoEventModel(OrderEntity orderEntity)
		{
			return new AddPaymentInfoEventModel
			{
				Event = EventType.AddPaymentInfo.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreateAddPaymentInfoECommerce(orderEntity)
			};
		}

		private PurchaseEventModel CreatePurchaseEventModel(OrderEntity orderEntity)
		{
			return new PurchaseEventModel
			{
				Event = EventType.Purchase.EnumMemberValue(),
				ECommerce = _eCommerceFactory.CreatePurchaseECommerce(orderEntity)
			};
		}
	}
}