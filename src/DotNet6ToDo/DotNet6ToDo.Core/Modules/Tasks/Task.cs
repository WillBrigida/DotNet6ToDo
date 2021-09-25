using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet6ToDo.Core.Modules.Tasks
{
    public class Task
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public DateTime DateTime { get; set; }
    }
}
