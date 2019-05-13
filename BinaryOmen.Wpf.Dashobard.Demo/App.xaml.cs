using BinaryOmen.Wpf.Dashobard.Demo.Views;
using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace BinaryOmen.Wpf.Dashobard.Demo
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
