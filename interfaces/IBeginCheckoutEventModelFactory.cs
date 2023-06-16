using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.interfaces
{
    internal interface IBeginCheckoutEventModelFactory
    {
        BeginCheckoutEventModel Create(OrderEntity orderEntity);
    }
}