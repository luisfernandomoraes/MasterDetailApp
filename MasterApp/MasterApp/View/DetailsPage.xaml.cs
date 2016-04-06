using MasterApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterApp.View
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Monkey monkey)
        {
            InitializeComponent();
            this.BindingContext = monkey;
        }
    }
}