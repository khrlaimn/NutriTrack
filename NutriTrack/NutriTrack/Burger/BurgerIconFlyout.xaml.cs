using NutriTrack.Expenses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NutriTrack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BurgerIconFlyout : ContentPage
    {
        public ListView ListView;

        public BurgerIconFlyout()
        {
            InitializeComponent();

            BindingContext = new BurgerIconFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class BurgerIconFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<BurgerIconFlyoutMenuItem> MenuItems { get; set; }
            
            public BurgerIconFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<BurgerIconFlyoutMenuItem>(new[]
                {
                    new BurgerIconFlyoutMenuItem { Id = 0, Title = "Home",
                    TargetType=typeof(MainPage) },

                    new BurgerIconFlyoutMenuItem { Id = 1, Title = "Add Expenses",
                    TargetType=typeof(FoodModel)},

                    new BurgerIconFlyoutMenuItem { Id = 2, Title = "Expenses Record",
                     TargetType=typeof(FoodRecord)},

                    new BurgerIconFlyoutMenuItem { Id = 3, Title = "Profile",
                    TargetType=typeof(ProfilePage)},

                    new BurgerIconFlyoutMenuItem { Id = 4, Title = "About Us",
                     TargetType=typeof(AboutUs) }
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}