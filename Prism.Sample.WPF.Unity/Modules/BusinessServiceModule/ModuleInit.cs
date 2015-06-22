using BusinessServiceInterface;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceModule
{
	public class ModuleInit : IModule
	{
		private readonly IUnityContainer _container;

		public ModuleInit(IUnityContainer container)
		{
			_container = container;
		}

        public void Initialize()
		{
            _container.RegisterType<IBusinessService, BusinessService>();
        }
    }
}
