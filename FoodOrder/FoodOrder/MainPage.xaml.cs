using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrder.Models;
using FoodOrder.ViewModels;
using Xamarin.Forms;

namespace FoodOrder
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;
        public MainPage()
        {
            vm = new MainPageViewModel();
            InitializeComponent();
            this.BindingContext = vm;
        }

        void TabView_SelectionChanged(System.Object sender, Xamarin.CommunityToolkit.UI.Views.TabSelectionChangedEventArgs e)
        {
            try
            {
                var item = e.NewPosition;
                vm.SelectedTabViewCommandExecuted(item);
            }
            catch(Exception ex)
            {

            }
        }

        void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            try
            {
                if(e.CurrentSelection.Count > 0)
                {
                    var item = e.CurrentSelection[0] as FoodModel;
                    vm.AddCartCommandExecuted(item);
                    ((CollectionView)sender).SelectedItem = null;
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
