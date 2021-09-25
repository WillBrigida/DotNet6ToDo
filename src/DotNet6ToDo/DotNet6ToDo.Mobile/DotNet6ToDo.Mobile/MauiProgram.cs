using DotNet6ToDo.Mobile.Modules.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace DotNet6ToDo.Mobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            #region Views
            builder.Services.AddTransient<DotNet6ToDo.Mobile.Modules.Home.HomePage>();
            builder.Services.AddTransient<DotNet6ToDo.Mobile.Modules.Tasks.TasksPage>();
            #endregion

            #region ViewModels
            builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Home.HomePageViewModel>();
            builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Tasks.TasksPageViewModel>();
            #endregion

            #region Services
            builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Services.INavigationService, NavigationService>();
            //builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Services.IDialogService, DialogService>();
            #endregion

            return builder.Build();
        }
    }
}