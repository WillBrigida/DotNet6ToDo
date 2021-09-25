namespace DotNet6ToDo.Core.Modules.Services
{
    public interface INavigationService
    {
        Task NavigateTo(string uri);
    }
}
