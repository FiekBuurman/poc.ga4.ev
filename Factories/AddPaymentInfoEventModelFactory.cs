using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal class AddPaymentInfoEventModelFactory : IAddPaymentInfoEventModelFactory
    {
        public AddPaymentInfoEventModel Create(OrderEntity orderEntity)
		{
			return new AddPaymentInfoEventModel();
        }
	}
}