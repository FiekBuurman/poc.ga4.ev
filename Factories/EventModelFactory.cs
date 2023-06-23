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
			return new ViewItemListEventModel(EventType.ViewItemList)
			{
				ECommerce = _eCommerceFactory.CreateViewItemListECommerce(orderEntity)
			};
		}

		private SelectItemEventModel CreateSelectItemEventModel(OrderEntity orderEntity)
		{
			return new SelectItemEventModel(EventType.SelectItem)
			{
				ECommerce = _eCommerceFactory.CreateSelectItemECommerce(orderEntity)
			};
		}

		private ViewItemEventModel CreateViewItemEventModel(OrderEntity orderEntity)
		{
			return new ViewItemEventModel(EventType.ViewItem)
			{
				ECommerce = _eCommerceFactory.CreateViewItemECommerce(orderEntity)
			};
		}

		private AddToCartEventModel CreateAddToCartEventModel(OrderEntity orderEntity)
		{
			return new AddToCartEventModel(EventType.AddToCart)
			{
				ECommerce = _eCommerceFactory.CreateAddToCartECommerce(orderEntity)
			};
		}

		private RemoveFromCartEventModel CreateRemoveFromCartEventModel(OrderEntity orderEntity)
		{
			return new RemoveFromCartEventModel(EventType.RemoveFromCart)
			{
				ECommerce = _eCommerceFactory.CreateRemoveFromCartECommerce(orderEntity)
			};
		}

		private ViewCartEventModel CreateViewCartEventModel(OrderEntity orderEntity)
		{
			return new ViewCartEventModel(EventType.ViewCart)
			{
				ECommerce = _eCommerceFactory.CreateViewCartECommerce(orderEntity)
			};
		}

		private BeginCheckoutEventModel CreateBeginCheckoutEventModel(OrderEntity orderEntity)
		{
			return new BeginCheckoutEventModel(EventType.BeginCheckout)
			{
				ECommerce = _eCommerceFactory.CreateBeginCheckoutECommerce(orderEntity)
			};
		}

		private AddShippingInfoEventModel CreateAddShippingInfoEventModel(OrderEntity orderEntity)
		{
			return new AddShippingInfoEventModel(EventType.AddShippingInfo)
			{
				ECommerce = _eCommerceFactory.CreateAddShippingInfoECommerce(orderEntity)
			};
		}

		private AddPaymentInfoEventModel CreateAddPaymentInfoEventModel(OrderEntity orderEntity)
		{
			return new AddPaymentInfoEventModel(EventType.AddPaymentInfo)
			{
				ECommerce = _eCommerceFactory.CreateAddPaymentInfoECommerce(orderEntity)
			};
		}

		private PurchaseEventModel CreatePurchaseEventModel(OrderEntity orderEntity)
		{
			return new PurchaseEventModel(EventType.Purchase)
			{
				ECommerce = _eCommerceFactory.CreatePurchaseECommerce(orderEntity)
			};
		}
	}
}