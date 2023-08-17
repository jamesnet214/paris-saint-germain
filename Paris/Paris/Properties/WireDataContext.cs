using Jamesnet.Wpf.Global.Location;
using Paris.Forms.Local.ViewModels;
using Paris.Forms.UI.Views;
using Paris.Main.Local.ViewModels;
using Paris.Main.Views;

namespace Paris.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<MainContent, MainContentViewModel>();
            items.Register<ParisWindow, ParisWindowViewModel>();
        }
    }
}
