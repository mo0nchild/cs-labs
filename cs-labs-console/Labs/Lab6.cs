using CSharpLabs.Supports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab6", 6)]
    public class Lab6 : ILabRunner
    {
        public Lab6() : base() { }

        public void RunLab()
        {
            Console.WriteLine("Нажмите для продолжения");
            Console.ReadKey();
        }
    }
}
