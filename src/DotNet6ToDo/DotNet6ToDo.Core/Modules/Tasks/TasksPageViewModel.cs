using DotNet6ToDo.Core.Modules.BaseVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6ToDo.Core.Modules.Tasks
{
    public class TasksPageViewModel : BaseViewModel
    {
        public MvvmHelpers.ObservableRangeCollection<Task> Tasks { get; set; }
        public TasksPageViewModel()
        {
            Tasks = new MvvmHelpers.ObservableRangeCollection<Task>();
            Title = "Tarefas";
        }
    }
}
