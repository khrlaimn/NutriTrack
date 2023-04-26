using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Runtime.CompilerServices;

namespace NutriTrack
{
    public partial class FoodModel : ContentPage
    {
        ObservableCollection<Foods> food;
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public FoodModel()
        {
            InitializeComponent();

            food = new ObservableCollection<Foods>
            {
                new Foods{FoodName="Nasi Ayam", FoodStallName="Selera Indah", FoodImage="NasiAyam.png", FoodType="Breakast",
                    FoodPrice=10.00, FoodCalories="102", FoodCarbo="20", FoodFat="30", FoodProtein="50" },

                new Foods{FoodName="Nasi Goreng Cina", FoodStallName="Aneka Nasi Goreng", FoodImage="NasiGorengCina.jpeg", FoodType="Lunch",
                    FoodPrice=20.00, FoodCalories="112", FoodCarbo="23", FoodFat="36", FoodProtein="50" },

                new Foods{FoodName="Nasi Goreng Ayam", FoodStallName="Aneka Nasi Goreng", FoodImage="NasiAyam.png", FoodType="Dinner",
                    FoodPrice=20.00, FoodCalories="132", FoodCarbo="30", FoodFat="60", FoodProtein="40" },
            };

            FoodCollectionView.ItemsSource = food;

            //private void OnSaveRecord(object sender, EventArgs e)
            //{
            //    var item = (sender as Button).BindingContext as Foods;
            //}

        }
    }
}