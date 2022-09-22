using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs.Lab1
{
    [TaskLoader.LabConfiguration("Lab1", "Task1")]
    public class Task1 : TaskLoader.ILabRunner
    {
        public string TaskInfo => "Task1 Lab1 Info";

        public void RunTask()
        {
            Console.WriteLine("Calling RunTask from Lab1.Task1");
        }
    }
}
