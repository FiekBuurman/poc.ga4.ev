using poc.ga4.ev.EventModels;
using poc.ga4.ev.Models;
using poc.ga4.ev.Types;

namespace poc.ga4.ev.Factories
{
    internal interface IEventModelFactory
	{
		BaseEventModel Create(EventType eventType, OrderEntity orderEntity);
	}
}
