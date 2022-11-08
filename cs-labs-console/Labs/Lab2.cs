using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpLabs.Supports;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab2", 2)]
    public class Lab2 : ILabRunner
    {
        public Lab2() : base() { }

        public void RunLab()
        {
            Console.WriteLine("Нажмите для продолжения");
            Console.ReadKey();
        }
    }
}
