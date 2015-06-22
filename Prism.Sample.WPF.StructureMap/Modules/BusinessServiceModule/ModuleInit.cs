using BusinessServiceInterface;
using Prism.Modularity;
using Prism.StructureMap;
using StructureMap;
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
			RegisterServices();
		}

		private void RegisterServices()
		{
			_container.RegisterTypeIfMissing<IBusinessService, BusinessService>(true);
		}
	}
}
