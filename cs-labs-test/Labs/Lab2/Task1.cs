using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs.Lab2
{
    [TaskLoader.LabConfiguration("Lab2", "Task1")]
    public class Task1 : TaskLoader.ILabRunner
    {
        public string TaskInfo => "Task1 Lab2 Info";

        public void RunTask()
        {
            Console.WriteLine("Calling RunTask from Lab2.Task1");
        }
    }
}
