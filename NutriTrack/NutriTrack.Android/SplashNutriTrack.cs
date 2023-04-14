using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS; 

using static Android.Net.LocalSocketAddress;
using NutriTrack.Droid;

namespace NutriTrack.Droid
{
    [Activity(Label = "NutriTrack", Icon = "@drawable/ic_launcher", Theme = "@style/Splash", MainLauncher = true)]
    public class SplashNutriTrack : Activity
    {
        public SplashNutriTrack()
        {
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Window.DecorView.SetBackgroundColor(Android.Graphics.Color.White);
            Finish();
        }


    }
}
