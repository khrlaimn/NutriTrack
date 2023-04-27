using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Essentials;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace NutriTrack
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://nutritrack-ka01-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task AddRecord(string fn, double fp, string fc, string fcarb, string fat, string protein, string ft, string dt, double tp)

                {
                    await firebase.Child("Foods").PostAsync(new Foods() 
                    {
                        FoodName = fn, FoodPrice = fp, FoodCalories = fc, FoodCarbo = fcarb, FoodFat = fat, 
                        FoodProtein = protein, FoodType = ft, DateRecorded = dt, TotalPrice = tp
                    });
                }
        public async Task<List<Foods>> GetAllExpensesRecord()
            {
                return (await firebase.Child("Foods").OnceAsync<Foods>()).Select(item => new Foods
                {
                    FoodName = item.Object.FoodName,
                    FoodPrice = item.Object.FoodPrice,
                    FoodCalories = item.Object.FoodCalories,
                    FoodCarbo = item.Object.FoodCarbo,
                    FoodFat = item.Object.FoodFat,
                    FoodProtein = item.Object.FoodProtein,
                    FoodType = item.Object.FoodType,
                    DateRecorded = item.Object.DateRecorded,
                    TotalPrice = item.Object.TotalPrice
                }).ToList();
            }

        public async Task<List<Foods>> GetFindRecord(string FoodName)
            {
                var allFoodRecord = await GetAllExpensesRecord();
                await firebase.Child("Foods").OnceAsync<Foods>();
                return allFoodRecord.Where(a => a.FoodName == FoodName).ToList();
            }
    }
}