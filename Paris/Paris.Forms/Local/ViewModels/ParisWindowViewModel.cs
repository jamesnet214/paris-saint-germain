using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;

namespace Paris.Forms.Local.ViewModels
{
    public class ParisWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public ParisWindowViewModel(IContainerProvider containerProvider, IRegionManager regionManager) 
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
            ImportContent("MainRegion", "MainContent");
        }

        private void ImportContent(string regionName, string viewName)
        {
            IViewable content = _containerProvider.Resolve<IViewable>(viewName);
            IRegion region = _regionManager.Regions[regionName];
            
            if(!region.Views.Contains(content))
            {
                region.Add(content);
            }
            region.Activate(content);
        }
    }
}
