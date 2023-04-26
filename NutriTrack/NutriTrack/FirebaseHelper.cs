using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Essentials;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;

namespace NutriTrack
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://nutritrack-ka01-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task AddRecord(string dt, string ft, string fn, double fp, double tp)

        {
            await firebase.Child("Foods").PostAsync(new Foods() 
            { 
                DateRecorded = dt, FoodType = ft, FoodName = fn, FoodPrice = fp, TotalPrice = tp 
            });
        }
        public async Task<List<Foods>> GetAllMealTrackerRecord()
    {
        return (await firebase.Child("Foods").OnceAsync<Foods>()).Select(item => new Foods
        {
            DateRecorded = item.Object.DateRecorded,
            FoodType = item.Object.FoodType,
            FoodName = item.Object.FoodName,
            FoodPrice = item.Object.FoodPrice,
            TotalPrice = item.Object.TotalPrice
        }).ToList();
    }

        public async Task<List<Foods>> GetFindRecord(string FoodName)
        {
            var allMealTrackerRecord = await GetAllMealTrackerRecord();
            await firebase.Child("Foods").OnceAsync<Foods>();
            return allMealTrackerRecord.Where(a => a.FoodName == FoodName).ToList();
        }
    }
}