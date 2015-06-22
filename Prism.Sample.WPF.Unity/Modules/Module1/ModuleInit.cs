using Prism.Modularity;
using Prism.Regions;
using Module1.ViewModels;
using Module1.Views;
using System;
using Microsoft.Practices.Unity;

namespace Module1
{
	public class ModuleInit :  IModule
	{
		private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

		public ModuleInit(IRegionManager regionManager, IUnityContainer container)
		{
			_regionManager = regionManager;
            _container = container;
		}

        public void Initialize()
        {
            _container.RegisterType<IMainView, MainView>();

            IMainView view = _container.Resolve<IMainView>();
			_regionManager.Regions["MainRegion"].Add(view);
        }
    }
}
