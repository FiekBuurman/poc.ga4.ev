using poc.ga4.ev.EventModels;
using poc.ga4.ev.interfaces;
using poc.ga4.ev.Models;

namespace poc.ga4.ev.Factories
{
    internal class RemoveFromCartEventModelFactory : IRemoveFromCartEventModelFactory
    {
        public RemoveFromCartEventModel Create(OrderEntity orderEntity)
        {
            return new RemoveFromCartEventModel();
        }
    }
}