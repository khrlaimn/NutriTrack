using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NutriTrack
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dateLabel.Text += DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }
        async void OnBudgetingClick(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new AboutApp());
        }

    }
}
