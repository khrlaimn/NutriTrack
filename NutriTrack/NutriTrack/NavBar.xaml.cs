using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriTrack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavBar : TabbedPage
    {
        public NavBar ()
        {
            InitializeComponent();
            dateLabel.Text += DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }
        async void OnBudgetingClick(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new AboutUs());
        }
        async void OnAboutsUsclicked(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new AboutUs());
        }
    }
}