using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal interface IAddPaymentInfoEventModelFactory
    {
        AddPaymentInfoEventModel Create(OrderEntity orderEntity);
    }
}