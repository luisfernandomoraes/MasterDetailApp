using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp.ViewModels.Services
{
    public interface IMessegeService
    {
        Task ShowAsync(string title, string message, string ok);
    }
}
