using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace DotNet6ToDo.Mobile.Modules.Tasks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TasksPage : ContentPage
    {
        public TasksPage(Core.Modules.Tasks.TasksPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
