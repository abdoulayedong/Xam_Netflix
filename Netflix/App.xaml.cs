using FreshMvvm;
using Netflix.PageModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Netflix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var page = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var navigationContainer = new FreshNavigationContainer(page);
            MainPage = navigationContainer;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
