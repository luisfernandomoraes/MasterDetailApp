using MasterApp.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp.View.Services
{
    public class MessageService : IMessegeService
    {
        public async Task ShowAsync(string title, string message, string ok)
        {
            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(title, message, ok);
        }


        public async Task DisplayActionSheet(string title, string cancel, string destruction, params string[] options)
        {
            await Xamarin.Forms.Application.Current.MainPage.DisplayActionSheet(title, cancel, destruction, options);
        }
    }
}
