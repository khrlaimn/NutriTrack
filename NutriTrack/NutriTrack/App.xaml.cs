using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriTrack
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new BurgerIcon();
            //MainPage = new NavBarTop();7
            MainPage = new NavigationPage(new NavBar());
            //MainPage = new NavigationPage(new NavBar());
            //NavigationPage.SetHasNavigationBar(MainPage, false);

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
