using System;
using System.Collections.Generic;
using System.Text;

namespace NutriTrack
{
    internal class FoodRecord
    {
        public string DateRecorded { get; set; }
        public string FoodName { get; set; }
        public string FoodStallName { get; set; }
        public string FoodImage { get; set; }
        public double FoodPrice { get; set; }
        public double FoodCalories { get; set; }
        public double FoodCarbo { get; set; }
        public double FoodFat { get; set; }
        public double FoodProtein{ get; set; }
    }
}
