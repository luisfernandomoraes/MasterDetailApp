using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterApp
{
    public partial class Promotions : ContentPage
    {
        public Promotions()
        {
            InitializeComponent();
            var vm = new PromotionViewModel();
            this.BindingContext = vm;
        }

        public void OnItemTapped(object o, EventArgs evt)
        {
			
        }
		
    }
}
