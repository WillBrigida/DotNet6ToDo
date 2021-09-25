using DotNet6ToDo.Core.Modules.BaseVM;
using DotNet6ToDo.Core.Modules.Services;
using DotNet6ToDo.Core.Modules.Tasks;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace DotNet6ToDo.Core.Modules.Home
{
    public class HomePageViewModel : BaseViewModel
    {
        readonly INavigationService _navigationService;
        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService= navigationService;
            Title = "Home";
        }

        public ICommand NavigationTest => new Command(async () => 
        {
            await _navigationService.NavigateTo(nameof(TaskPageViewModel));
        });
    }
}
