using CSharpLabs.Supports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab9
{
    [type: LabDetectAttribute("WinformLab9", 9)]
    internal class LabLinker9 : object, ILabRunner
    {
        public void RunLab()
        {
            var loader = new LabsLoader.TaskLoader(Assembly.GetExecutingAssembly(), GetType());
            new LabsLoader.MainMenu(loader).ShowDialog();
        }
    }
}
