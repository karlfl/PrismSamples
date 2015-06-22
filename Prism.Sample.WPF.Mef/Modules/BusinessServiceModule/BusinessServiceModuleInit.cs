using Prism.Modularity;
using Prism.Mef.Modularity;

namespace BusinessServiceModule
{
    [ModuleExport(typeof(BusinessServiceModuleInit))]
	public class BusinessServiceModuleInit : IModule
	{
        public void Initialize()
		{
        }
    }
}
