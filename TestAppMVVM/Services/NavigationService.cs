using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreadCommunity.Interfaces;
using Prism.Regions;
using TestAppMVVM.Views;

namespace TestAppMVVM.Services
{
    public class NavigationService : INavigationService
    {
        private const string CONTENT_REG1 = "ContentRegion1";
        private const string CONTENT_REG2 = "ContentRegion2";
        private const string CONTENT_REG3 = "ContentRegion3";
        private const string CONTENT_REG4 = "ContentRegion4";
  
        private readonly IRegionManager _regionmanager;
        public NavigationService (IRegionManager regionManager)
        {
            _regionmanager = regionManager ?? throw new ArgumentNullException(nameof(regionManager));
            LoadPage1();
        }

        public void LoadPage1()
        {
            _regionmanager.RequestNavigate(CONTENT_REG2, nameof(Page1View));
        }
        public void LoadPage2()
        {
            _regionmanager.RequestNavigate(CONTENT_REG2, nameof(Page2View));
        }
        public void LoadPage3()
        {
            _regionmanager.RequestNavigate(CONTENT_REG2, nameof(Page3View));
        }
        public void LoadPage4()
        {
            _regionmanager.RequestNavigate(CONTENT_REG4, nameof(SendTelegramMessageView));
        }
        public void LoadPage5()
        {
            _regionmanager.RequestNavigate(CONTENT_REG4, nameof(SendTelegramDocumentView));
        }
        public void LoadPage6()
        {
            _regionmanager.RequestNavigate(CONTENT_REG4, nameof(RecivePLCDataView));
        }
    }
}
