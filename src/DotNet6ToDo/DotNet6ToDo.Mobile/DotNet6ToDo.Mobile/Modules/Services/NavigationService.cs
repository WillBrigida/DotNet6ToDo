using DotNet6ToDo.Mobile.Modules.Home;
using DotNet6ToDo.Mobile.Modules.Tasks;
using System.Threading.Tasks;

namespace DotNet6ToDo.Mobile.Modules.Services
{
    public class NavigationService : DotNet6ToDo.Core.Modules.Services.INavigationService
    {
        readonly TasksPage _tasksPage;
        public NavigationService(TasksPage tasksPage) => _tasksPage = tasksPage;

        public async Task NavigateTo(string uri)
        {
            await App.Current.MainPage.Navigation.PushAsync(_tasksPage);
        }
    }
}
