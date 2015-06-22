using BusinessServiceInterface;
using Prism.Modularity;
using Prism.Autofac;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServiceModule
{
	public class ModuleInit : IModule
	{
		private readonly IContainer _container;

		public ModuleInit(IContainer container)
		{
			_container = container;
		}

        public void Initialize()
		{
            var builder = new ContainerBuilder();
            builder.RegisterType<BusinessService>().As<IBusinessService>();
            builder.Update(_container);
        }
    }
}
