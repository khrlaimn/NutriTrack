using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace NutriTrack
{
    public partial class FoodRecord : TabbedPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public FoodRecord()
        {
            InitializeComponent();
        }

        async override protected void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            if (CurrentPage is ContentPage OverallRecordsTab)
            {
                base.OnAppearing();
                display.ItemsSource = await firebaseHelper.GetAllExpensesRecord();
            }
            else if (CurrentPage is ContentPage FindStatusTab)
            {
                base.OnAppearing();
            }
        }
    }
}