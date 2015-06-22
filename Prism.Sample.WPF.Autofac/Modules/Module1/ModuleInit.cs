using Prism.Modularity;
using Prism.Regions;
using Autofac;
using Module1.ViewModels;
using Prism.Autofac;
using Module1.Views;
using System;

namespace Module1
{
	public class ModuleInit :  IModule
	{
		private readonly IRegionManager _regionManager;
        private readonly IContainer _container;

		public ModuleInit(IRegionManager regionManager, IContainer container)
		{
			_regionManager = regionManager;
            _container = container;
		}

        public void Initialize()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainView>().As<IMainView>();
            builder.Update(_container);

            IMainView view = _container.Resolve<IMainView>();
			_regionManager.Regions["MainRegion"].Add(view);
        }
    }
}
