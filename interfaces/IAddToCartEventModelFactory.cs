using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.interfaces
{
    internal interface IAddToCartEventModelFactory
    {
        AddToCartEventModel Create(OrderEntity orderEntity);
    }
}