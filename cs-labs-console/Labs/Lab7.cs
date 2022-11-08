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
    [type: LabDetectAttribute("ConsoleLab7", 7)]
    public class Lab7 : ILabRunner
    {
        public Lab7() : base() { }

        public void RunLab()
        {
            Console.WriteLine("Нажмите для продолжения");
            Console.ReadKey();
        }
    }
}
