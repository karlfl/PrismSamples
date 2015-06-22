using BusinessServiceInterface;
using Prism.Modularity;
using Prism.Ninject;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceModule
{
	public class ModuleInit : IModule
	{
		private readonly IKernel _kernel;

		public ModuleInit(IKernel kernel)
		{
            _kernel = kernel;
		}

        public void Initialize()
		{
            _kernel.Bind<IBusinessService>().To<BusinessService>();
        }
    }
}
