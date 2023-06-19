using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal class EventModelFactory : IEventModelFactory
    {
        public AddPaymentInfoEventModel CreateAddPaymentInfoEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public AddShippingInfoEventModel CreateAddShippingInfoEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public AddToCartEventModel CreateAddToCartEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public BeginCheckoutEventModel CreateBeginCheckoutEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public PurchaseEventModel CreatePurchaseEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public RemoveFromCartEventModel CreateRemoveFromCartEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public SelectItemEventModel CreateSelectItemEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public ViewCartEventModel CreateViewCartEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public ViewItemEventModel CreateViewItemEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }

        public ViewItemListEventModel CreateViewItemListEventModel(OrderEntity orderEntity)
        {
            throw new System.NotImplementedException();
        }
    }
}