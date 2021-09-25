namespace DotNet6ToDo.Core.Modules.Services
{
    public interface IDialogService
    {
        Task Alert(string title, string message, string ok = "OK");
    }
}
