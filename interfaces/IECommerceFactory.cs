using poc.ga4.ev.Models;

namespace poc.ga4.ev.interfaces
{
    internal interface IECommerceFactory
    {
		public ViewItemListECommerce CreateViewItemListECommerce(OrderEntity orderEntity);
        public SelectItemECommerce CreateSelectItemECommerce(OrderEntity orderEntity);
        public ViewItemECommerce CreateViewItemECommerce(OrderEntity orderEntity);
        public AddToCartECommerce CreateAddToCartECommerce(OrderEntity orderEntity);
        public RemoveFromCartECommerce CreateRemoveFromCartECommerce(OrderEntity orderEntity);
        public ViewCartECommerce CreateViewCartECommerce(OrderEntity orderEntity);
        public BeginCheckoutECommerce CreateBeginCheckoutECommerce(OrderEntity orderEntity);
        public AddShippingInfoECommmerce CreateAddShippingInfoECommerce(OrderEntity orderEntity);
        public AddPaymentInfoECommerce CreateAddPaymentInfoECommerce(OrderEntity orderEntity);
        public PurchaseECommerce CreatePurchaseECommerce(OrderEntity orderEntity);
    }
}