using poc.ga4.ev.EventModels;
using poc.ga4.ev.interfaces;

namespace poc.ga4.ev.Factories
{
    internal class SelectItemEventModelFactory : ISelectItemEventModelFactory
    {
        public SelectItemEventModel Create()
        {
            return new SelectItemEventModel();
        }
    }
}