using Prism.Modularity;
using Prism.Regions;
using Ninject;
using Prism.Ninject;
using Module1.Views;
using System;

namespace Module1
{
	public class ModuleInit :  IModule
	{
		private readonly IRegionManager _regionManager;
        private readonly IKernel _kernel;

		public ModuleInit(IRegionManager regionManager, IKernel kernel)
		{
			_regionManager = regionManager;
            _kernel = kernel;
		}

        public void Initialize()
        {
            _kernel.Bind<IMainView>().To<MainView>();

            IMainView view = _kernel.Get<IMainView>();
			_regionManager.Regions["MainRegion"].Add(view);
        }
    }
}
