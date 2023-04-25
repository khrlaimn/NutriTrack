using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace NutriTrack
{
	public partial class FoodModel : ContentPage
	{
		ObservableCollection<Foods> food;
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ExpensesRecord.txt");
        public FoodModel()
		{
			InitializeComponent();

			food = new ObservableCollection<Foods>
			{
				new Foods{FoodName="Nasi Ayam", FoodStallName="Selera Indah", FoodImage="NasiAyam.png",
					FoodPrice=10.00, FoodCalories=102, FoodCarbo=20, FoodFat=30, FoodProtein=50 },

				new Foods{FoodName="Nasi Goreng Cina", FoodStallName="Aneka Nasi Goreng", FoodImage="NasiGorengCina.jpeg",
                    FoodPrice=20.00, FoodCalories=102, FoodCarbo=20, FoodFat=30, FoodProtein=50 },

                new Foods{FoodName="Nasi Goreng Ayam", FoodStallName="Aneka Nasi Goreng", FoodImage="NasiAyam.png",
                    FoodPrice=20.00, FoodCalories=122, FoodCarbo=80, FoodFat=50, FoodProtein=40 },
            };

            FoodCollectionView.ItemsSource = food;

            void SaveButton(object sender, EventArgs e)
            {
                
                File.AppendAllText(fileName, Environment.NewLine);
            }


        }
    }
}