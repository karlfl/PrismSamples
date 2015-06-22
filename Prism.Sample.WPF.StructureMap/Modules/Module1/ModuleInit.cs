using Prism.Modularity;
using Prism.Regions;
using StructureMap;
using Module1.ViewModels;
using Prism.StructureMap;
using Module1.Views;

namespace Module1
{
	public class ModuleInit : IModule
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
            _container.RegisterTypeIfMissing<IMainView, MainView>(false);

            IMainView view = _container.GetInstance<IMainView>();
			_regionManager.Regions["MainRegion"].Add(view);
		}
	}
}
