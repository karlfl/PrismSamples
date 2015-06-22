using Module1.Views;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace Module1
{
    [ModuleExport(typeof(Module1Init))]
    public class Module1Init :  IModule
	{
		private readonly IRegionManager _regionManager;
        private readonly IMainView _mainView;

        [ImportingConstructor]
        public Module1Init(IRegionManager regionManager, IMainView mainView)
		{
			_regionManager = regionManager;
            _mainView = mainView;
		}

        public void Initialize()
        {
			_regionManager.Regions["MainRegion"].Add(_mainView);
        }
    }
}
