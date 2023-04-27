using NutriTrack.Expenses;
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
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            dateLabel.Text += DateTime.Now.ToString("dddd, MMMM dd yyyy");
        }
        async void OnExpensesClick(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new ExpensesForm());
        }
        async void OnBudgetingClick(object sender, EventArgs args)
        {

            await Navigation.PushAsync(new FoodRecord());
        }
    }
}