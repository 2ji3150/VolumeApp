using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Unity;
using Xamarin.Forms;
using VolumeApp.Views;
using VolumeApp.ViewModels;

namespace VolumeApp {
    public partial class App : PrismApplication {     
        protected override void OnInitialized() {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes() => Container.RegisterTypeForNavigation<MainPage>();        
    }
}
