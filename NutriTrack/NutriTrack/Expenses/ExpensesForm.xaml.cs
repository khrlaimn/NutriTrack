using NutriTrack;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;


namespace NutriTrack.Expenses
{
    public partial class ExpensesForm : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        private double totalPrice = 0.00;
        public ExpensesForm()
        {
            InitializeComponent();
        }

        void OnAdd(object sender, EventArgs e)
        {
            //Food Name
            string name = inputFoodName.Text;
            resFoodName.Text = "Food Name: " + name;

            //Food Price
            double price = Convert.ToDouble(inputFoodPrice.Text);
            resFoodPrice.Text = "Price: RM" + price.ToString("0.00");

            //Food Type
            string selectedFood = foodType.SelectedItem as string;
            resFoodType.Text = "Food Type: " + selectedFood;

            //Food Calories
            string cal = inputCalories.Text;
            resCalories.Text = "Calories: " + cal;

            //Food Carbo
            string carbo = inputCarbo.Text;
            resCarbo.Text = "Carbo: " + carbo;

            //Food Fat
            string fat = inputFat.Text;
            resFat.Text = "Fat: " + fat;

            //Food Protein
            string protein = inputProtein.Text;
            resProtein.Text = "Protein: " + protein;
        }
        
        //Reset Button
        void OnReset(object sender, EventArgs e)
        {
            inputFoodName.Text = "";
            inputFoodPrice.Text = "";
            inputCalories.Text = "";
            inputCarbo.Text = "";
            inputFat.Text = "";
            inputProtein.Text = "";
            foodType.SelectedIndex = -1;
            resFoodName.Text = "Food Name: ";
            resFoodPrice.Text = "Price: RM";
            resCalories.Text = "Calories: ";
            resCarbo.Text = "Carbo: ";
            resFat.Text = "Fat: ";
            resProtein.Text = "Protein: ";
            resFoodType.Text = "Food Type: ";
        }

        //Date
        void onDatePickerSelected(object sender, DateChangedEventArgs e)
        {
            var selectedDate = e.NewDate.ToString();
        }

        //Save Button, Display
        async void OnSaveRecord(object sender, EventArgs e)
        {

            string name = inputFoodName.Text;
            resFoodName.Text = "Food Name: " + name;

            double price = Convert.ToDouble(inputFoodPrice.Text);
            resFoodPrice.Text = "Price: RM" + price.ToString("0.00");

            string cal = inputCalories.Text;
            resCalories.Text = "Calories: " + cal;

            string carbo = inputCarbo.Text;
            resCarbo.Text = "Carbo: " + carbo;

            string fat = inputFat.Text;
            resFat.Text = "Fat: " + fat;

            string protein = inputProtein.Text;
            resProtein.Text = "Protein: " + protein;

            string selectedFoodType = foodType.SelectedItem as string;
            resFoodType.Text = "Food Type: " + selectedFoodType;

            var selectdate = selectDate.Date.ToString("dd/MM/yyyy");

            // Update Total Price 
            totalPrice = totalPrice += price;
            resFoodTotal.Text = "Total: RM" + totalPrice.ToString("0.00");

            await firebaseHelper.AddRecord(name, price, cal, carbo, fat, protein, selectedFoodType, selectdate, totalPrice);

            await DisplayAlert("Record Saved", "Expense Record Saved ^_^", "OK");
        }
    }

}