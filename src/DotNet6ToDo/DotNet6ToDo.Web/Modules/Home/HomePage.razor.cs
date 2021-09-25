using DotNet6ToDo.Core.Modules.Home;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace DotNet6ToDo.Web.Modules.Home
{
    public partial class HomePage
    {
        [Inject] public HomePageViewModel VM { get; set; }

        protected override async System.Threading.Tasks.Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                VM.PropertyChanged += PropertyChangedEvent();
            }
            await base.OnInitializedAsync();
        }

        private PropertyChangedEventHandler PropertyChangedEvent()
        {
            return async (sender, e) =>
            {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };
        }

        public void Dispose() => VM.PropertyChanged -= PropertyChangedEvent();
    }
}
