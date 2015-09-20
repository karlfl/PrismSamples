using Prism.Modularity;
using Prism.Regions;
using Module1.ViewModels;
using Module1.Views;
using System;
using Microsoft.Practices.Unity;

//TODO: 5. Create your first Module by creating a new Class Library project and adding a ModuleInit.cs file
namespace Module1
{
    // TODO: 6. Implement the IModule interface
    public class ModuleInit : IModule
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        //TODO: 7. During construction Unity will inject the Region Manager and Container.
        //   Other objects can also be injected here or with code attributes on the class properties
        public ModuleInit(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        //TODO: 8. Implement the Initialize method to provide an entry point for your modules startup code.
        //   Here we are getting an instance of the Main View using the container (after first registering it in the container).
        //   Then we are placing that instance in the "MainRegion" which is found/defined on the Shell object.
        public void Initialize()
        {
            _container.RegisterType<IMainView, MainView>();

            IMainView view = _container.Resolve<IMainView>();
            _regionManager.Regions["MainRegion"].Add(view);
        }
    }
}
