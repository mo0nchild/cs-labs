using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs.Lab1
{
    [type: TaskLoader.LabConfiguration("Lab1", "Task2")]
    public class Task2 : TaskLoader.ILabRunner
    {
        public string TaskInfo => "Task2 Lab1 Info";

        public void RunTask()
        {
            Console.WriteLine("Calling RunTask from Lab1.Task2");
        }
    }
}
