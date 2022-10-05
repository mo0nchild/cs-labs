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
            var cursor_position = default(int);
            while (true) 
            {
                Console.WriteLine("Список доступных лабораторных работ: ");
                for (int i = 0; i < labs_types.TypesListCount; i++)
                {
                    Console.Write("    {0}", (i == cursor_position) ? "-> " : "   ");
                    Console.WriteLine($"[{i + 1}]\tClassName: {labs_types[i].Type.Name}; LabName: {labs_types[i].Name}");
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow: cursor_position += ((cursor_position <= 0) ? 0 : -1); break;
                    case ConsoleKey.DownArrow:
                        cursor_position += ((cursor_position >= labs_types.TypesListCount - 1) ? 0 : 1); break;

                    case ConsoleKey.Enter: labs_types.InvokeTask(cursor_position);
                        Console.WriteLine("Нажмите клавишу для продолжения");
                        Console.ReadKey(); break;
                }
                Console.Clear();
            }
        }
    }
}
