using DotNet6ToDo.Core.Modules.Services;
using Microsoft.AspNetCore.Components;

namespace DotNet6ToDo.Web.Modules.Services
{
    public class NavigationService : INavigationService
    {
        readonly NavigationManager _navigationManager;

        public NavigationService(NavigationManager navigationManager) => _navigationManager = navigationManager;

        public async Task NavigateTo(string uri)
        {
            await Task.Run(() => _navigationManager.NavigateTo("/tasks"));
        }
    }
}
