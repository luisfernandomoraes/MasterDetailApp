using MasterApp.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterApp.Model;

namespace MasterApp.View.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateTo(string viewName, object param)
        {
            throw new NotImplementedException();
        }

        public Task NavigateToDetails(Monkey monkey)
        {
            throw new NotImplementedException();
        }

        public Task ShowProperties()
        {
            //App.Current.MainPage.Navigation.PushAsync()
            return null;
        }
    }
}
