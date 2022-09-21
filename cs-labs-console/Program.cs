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
            var labs_types = new LoaderSupport(Assembly.GetExecutingAssembly());
            while (true) 
            {
                Console.WriteLine("Список доступных лабораторных работ: ");
                for (int i = 0; i < labs_types.TypesListCount; i++) 
                {
                    Console.WriteLine($"\t- [{i + 1}] {labs_types[i].Type.Name}: {labs_types[i].Name}");
                }

                Console.Write("Выберите номер лабораторной работы: ");
                try 
                {
                    int lab_select = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    labs_types.InvokeTask(lab_select - 1);
                }
                catch (Exception error) { Console.WriteLine(error.Message); }

                Console.WriteLine("Нажмите клавишу для продолжения");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
