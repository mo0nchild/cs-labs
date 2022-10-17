using CSharpLabs.Supports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab6
{
    [type: LabDetectAttribute("WinformLab6", 6)]
    internal class LabLinker6 : object, ILabRunner
    {
        public void RunLab()
        {
            var loader = new LabsLoader.TaskLoader(Assembly.GetExecutingAssembly(), this.GetType());
            new LabsLoader.MainMenu(loader).ShowDialog();
        }
    }
}
