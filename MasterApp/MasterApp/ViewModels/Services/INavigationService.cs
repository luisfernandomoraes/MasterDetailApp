using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterApp.ViewModels.Services
{
    public interface INavigationService
    {
        Task NavigateTo(string viewName, object param);
        Task ShowProperties();
        Task NavigateToDetails(Model.Monkey monkey);
    }
}
