using ETABSPlugin_Prism.Views;
using ETABSPlugin_Prism.ViewModels;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace ETABSPlugin_Prism
{
    public class Bootstrapper : PrismBootstrapperBase
    {
        protected override IContainerExtension CreateContainerExtension()
        {
            return new UnityContainerExtension();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IMainViewModel, MainViewModel>();
        }
    }
}