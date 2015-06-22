using System;
using System.Windows;
using Prism.Modularity;
using Prism.Autofac;

namespace WPFPrismTest
{
    //TODO: 1. Create a UnityBootstrapper Class
    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog catalog = (ModuleCatalog)this.ModuleCatalog;

            AddModuleToCatalog(typeof(BusinessServiceModule.ModuleInit), catalog);
            AddModuleToCatalog(typeof(Module1.ModuleInit), catalog);
        }

        private void AddModuleToCatalog(Type ModuleType, ModuleCatalog Catalog)
        {
            ModuleInfo NewModuleInfo = new ModuleInfo()
            {
                ModuleName = ModuleType.AssemblyQualifiedName,
                ModuleType = ModuleType.AssemblyQualifiedName
            };
            Catalog.AddModule(NewModuleInfo);
        }
    }
}
