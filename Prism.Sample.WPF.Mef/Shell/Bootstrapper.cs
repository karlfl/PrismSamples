using System;
using System.Windows;
using Prism.Modularity;
using Prism.Mef;
using System.ComponentModel.Composition.Hosting;

namespace WPFPrismTest
{
    //TODO: 1. Create a UnityBootstrapper Class
    class Bootstrapper : MefBootstrapper
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

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(BusinessServiceModule.BusinessServiceModuleInit).Assembly));
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Module1.Module1Init).Assembly));
        }
    }
}
