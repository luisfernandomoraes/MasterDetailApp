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

        public async Task NavigateToDetails(Monkey monkey)
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Outra());
        }

        public async Task ShowProperties()
        {
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushModalAsync(new Outra());
        }
    }
}
