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
        private double totalSpent = 0.00;
        public ExpensesForm()
        {
            InitializeComponent();
        }

        void OnAdd(object sender, EventArgs e)
        {
            //Food Name
            string name = inputFoodName.Text;
            resFoodName.Text = name;

            //Food Price
            double price = Convert.ToDouble(inputFoodPrice.Text);
            resFoodPrice.Text = "RM" + price.ToString("0.00");

            //Food Type
            string selectedFood = foodType.SelectedItem as string;
            resFoodType.Text = selectedFood;
        }
        
        //Reset Button
        void OnReset(object sender, EventArgs e)
        {
            inputFoodName.Text = "";
            inputFoodPrice.Text = "";
            foodType.SelectedIndex = -1;
            resFoodName.Text = "Food Name: ";
            resFoodPrice.Text = "RM";
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

            var selectdate = selectDate.Date.ToString("dd/MM/yyyy");

            string name = inputFoodName.Text;
            resFoodName.Text = "Food Name: " + name;

            double price = Convert.ToDouble(inputFoodPrice.Text);
            resFoodPrice.Text = "RM" + price.ToString("0.00");

            string selectedMeal = foodType.SelectedItem as string;
            resFoodType.Text = "Food Type: " + selectedMeal;

            // Update Total Price 
            totalSpent = totalSpent += price;
            resFoodTotal.Text = "Total: RM" + totalSpent.ToString("0.00");

            await firebaseHelper.AddRecord(selectdate, selectedMeal, name, price, totalSpent);

            await DisplayAlert("Record Saved", "Expense Record Saved ^_^", "OK");
        }
    }

}