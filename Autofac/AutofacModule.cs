using Autofac;
using MOS.Common.Core.Ioc.Helpers;

namespace poc.ga4.ev.Autofac
{
	public class AutofacModule : Module
	{
		protected override void Load(ContainerBuilder builder)
			=> AutofacHelper.ScanAssembly(ThisAssembly, builder);
	}
}
