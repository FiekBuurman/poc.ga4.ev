using poc.ga4.ev.Models;

namespace poc.ga4.ev.interfaces
{
    internal interface IECommerceFactory
	{
		public T CreateECommerce<T>(OrderEntity orderEntity) where T : BaseECommerce, new();
        public ViewCartECommerce CreateViewCartECommerce(OrderEntity orderEntity);
        public BeginCheckoutECommerce CreateBeginCheckoutECommerce(OrderEntity orderEntity);
        public AddShippingInfoECommmerce CreateAddShippingInfoECommerce(OrderEntity orderEntity);
        public AddPaymentInfoECommerce CreateAddPaymentInfoECommerce(OrderEntity orderEntity);
        public PurchaseECommerce CreatePurchaseECommerce(OrderEntity orderEntity);
    }
}