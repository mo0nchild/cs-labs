using System;
using System.Collections.Generic;
using System.Reflection;

using CSharpLabs.Supports;
using CSharpLabs.Labs;

namespace CSharpLabs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var labs_types = LabsLoaderSupport.GetLabsTypes();
            while (true) 
            {
                Console.WriteLine("Список доступных лабораторных работ: ");
                for (int i = 0; i < labs_types.Count; i++) Console.WriteLine($"\t- [{i+1}] {labs_types[i]}");
                Console.Write("Выберите номер лабораторной работы: ");

                try 
                {
                    int lab_select = int.Parse(Console.ReadLine()!);
                    object? lab_instance = Activator.CreateInstance(labs_types[lab_select - 1]);

                    labs_types[lab_select - 1].GetMethod("Run")?.Invoke(lab_instance, new object[] { });
                }
                catch (Exception error) { Console.WriteLine(error.Message); }

                Console.WriteLine("Нажмите клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
