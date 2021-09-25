using DotNet6ToDo.Mobile.Modules.Home;
using Microsoft.Maui.Controls;
using Application = Microsoft.Maui.Controls.Application;

namespace DotNet6ToDo.Mobile
{
    public partial class App : Application
    {
        public App(HomePage homepage)
        {
            InitializeComponent();

            MainPage = new NavigationPage(homepage);
        }
    }
}
