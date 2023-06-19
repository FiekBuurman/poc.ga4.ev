using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal interface IEventModelFactory
    {
        AddPaymentInfoEventModel CreateAddPaymentInfoEventModel(OrderEntity orderEntity);

        AddShippingInfoEventModel CreateAddShippingInfoEventModel(OrderEntity orderEntity);

        AddToCartEventModel CreateAddToCartEventModel(OrderEntity orderEntity);

        BeginCheckoutEventModel CreateBeginCheckoutEventModel(OrderEntity orderEntity);

        PurchaseEventModel CreatePurchaseEventModel(OrderEntity orderEntity);

        RemoveFromCartEventModel CreateRemoveFromCartEventModel(OrderEntity orderEntity);

        SelectItemEventModel CreateSelectItemEventModel(OrderEntity orderEntity);

        ViewCartEventModel CreateViewCartEventModel(OrderEntity orderEntity);

        ViewItemEventModel CreateViewItemEventModel(OrderEntity orderEntity);

        ViewItemListEventModel CreateViewItemListEventModel(OrderEntity orderEntity);
    }
}
