using DotNet6ToDo.Web;
using DotNet6ToDo.Web.Modules.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region Views
//builder.Services.AddTransient<DotNet6ToDo.Web.Modules.Home.HomePage>();
//builder.Services.AddTransient<DotNet6ToDo.Web.Modules.Tasks.TasksPage>();
#endregion

#region ViewModels
builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Home.HomePageViewModel>();
builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Tasks.TasksPageViewModel>();
#endregion

#region Services
builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Services.INavigationService, NavigationService>();
//builder.Services.AddTransient<DotNet6ToDo.Core.Modules.Services.IDialogService, DialogService>();
#endregion

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
