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
            //MainPage = new NavigationPage(new NavBar());
            MainPage = new BurgerIcon();

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
