using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using MasterApp;
using MasterApp.Model;
using MasterApp.ViewModels;
using MasterApp.View;

namespace MasterApp
{
    public partial class Promotions : ContentPage
    {
        public Promotions()
        {
            InitializeComponent();
            this.BindingContext = new MonkeysViewModel();
        }

        public void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var monkey = args.Item as Monkey;
            if (monkey == null)
                return;

            Navigation.PushAsync(new DetailsPage(monkey));
            // Reset the selected item
            list.SelectedItem = null;
        }

    }
}
