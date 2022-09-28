using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using CSharpLabs.Supports;

namespace CSharpLabs.Lab2
{
    [type: LabDetectAttribute("WinformLab2", 2)]
    internal class LabLinker3 : object, ILabRunner
    {
        public void RunLab()
        {
            var loader = new LabsLoader.TaskLoader(Assembly.GetExecutingAssembly(), this.GetType());
            new LabsLoader.MainMenu(loader).ShowDialog();
        }
    }
}
