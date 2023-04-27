using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriTrack
{
    public partial class ProfilePage : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public ProfilePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            display.ItemsSource = await firebaseHelper.GetAllExpensesRecord();
        }
    } 
}