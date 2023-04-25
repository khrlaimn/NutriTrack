using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriTrack
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodModel : ContentPage
	{
		public FoodModel ()
		{
			InitializeComponent ();
		}
	}
}