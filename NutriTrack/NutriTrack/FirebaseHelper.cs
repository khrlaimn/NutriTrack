using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Essentials;
using System.Linq;



namespace NutriTrack
{
    public class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://nutritrack-ka01-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public async Task AddRecord(string dt, string fn, string fsn, string fi, double fprice, double fc, double fcarb, double ff, double fp, double fp)
        {
            await firebase
                .Child("BmiRecords")
                .PostAsync(new FoodRecord() { DateRecorded = dt, FoodName = fn, FoodStallName = fsn, FoodImage= fi, FoodPrice = fprice, 
                    FoodCalories = fc, FoodCarbo = fcarb, FoodFat = ff, FoodProtein = fp });
        }

        public async Task<List<FoodRecord>> GetAllFoodRecord()
        {
            return (await firebase
                .Child("FoodRecord")
                .OnceAsync<FoodRecord>()).Select(item => new FoodRecord
                {
                    DateRecorded = item.Object.DateRecorded,
                    FoodName = item.Object.FoodName,
                    FoodStallName = item.Object.FoodStallName,
                    FoodImage = item.Object.FoodImage,
                    FoodPrice = item.Object.FoodPrice,
                    FoodCalories = item.Object.FoodCalories,
                    FoodCarbo = item.Object.FoodCarbo,
                    FoodFat = item.Object.FoodFat,
                    FoodProtein = item.Object.FoodProtein

    }).ToList();
        }
        public async Task<List<FoodRecord>> GetFindRecord(string bmistatus)
        {
            var allBmiRecord = await GetAllBmiRecord();
            await firebase
              .Child("BmiRecords")
              .OnceAsync<FoodRecord>();
            return allBmiRecord.Where(a => a.BmiStatus == bmistatus).ToList();
        }

    }
}
