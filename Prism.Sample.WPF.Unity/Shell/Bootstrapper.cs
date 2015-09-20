using System;
using System.Windows;
using Prism.Modularity;
using Prism.Unity;

namespace WPFPrismTest
{
    //TODO: 1. Create a UnityBootstrapper Class
    class Bootstrapper : UnityBootstrapper
    {
        //TODO: 2. Override the CreateShell returning an instance of your shell.
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        //TODO: 3. Override the InitializeShell setting the MainWindow on the application and showing the shell.
        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        //TODO: 4. Override the ConfigureModuleCatalog 
        //  When initializing the modules in code this is probably the place to do it.
        //  Review the ModuleInit.cs file in each module to see the continuation of the application initialization
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog catalog = (ModuleCatalog)this.ModuleCatalog;

            // In this example we are initializing two modules a Business Module with all of our business logic
            //  and a UI Module with some simple UI that will get data from the business module and display it
            //  ??? Order here doesn't imply load order.  For a  specific module loading order
            //      use a module catalog file and specify dependancies for each module. (more detail to be added)
            AddModuleToCatalog(typeof(BusinessServiceModule.ModuleInit), catalog);
            AddModuleToCatalog(typeof(Module1.ModuleInit), catalog);
        }

        //Supporting method to make step 4 easier.
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
