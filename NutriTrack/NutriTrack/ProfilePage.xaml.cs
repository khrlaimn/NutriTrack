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
        ObservableCollection<Foods> food;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public ProfilePage()
        {
            InitializeComponent();

            food = new ObservableCollection<Foods>
            {
                new Foods{FoodName="Nasi Ayam", FoodStallName="Selera Indah", FoodImage="NasiAyam.png", FoodType="Breakast",
                    FoodPrice=10.00, FoodCalories = "102", FoodCarbo = "20", FoodFat = "30", FoodProtein="50" }
            };
        }
    } 
}