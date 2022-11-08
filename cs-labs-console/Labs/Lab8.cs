using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using CSharpLabs.Supports;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab8", 8)]
    public class Lab8 : ILabRunner
    {
        public struct ResultData
        {
            public double SumModulus { get; set; }
            public double ProductSquare { get; set; }
        }
        public sealed class LabLogic : System.Object
        {
            public enum FileCreateMethod { FileCreate = 1, FileWriteAllText };
            public ResultData LabTask1(string filename, string numbers_str)
            {
                double sum_result = default, product_result = 1;
                using (var file = File.CreateText($"{filename}.txt"))
                {
                    foreach (var num in numbers_str.Split(' ')) file.WriteLine(num);
                }
                
                using (var file = File.OpenText($"{filename}.txt"))
                {
                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine()!;
                        try { 
                            sum_result += double.Parse(line);
                            product_result *= double.Parse(line);
                        }
                        catch { continue; }
                    }
                }
                var result = new ResultData () 
                { 
                    SumModulus = Math.Round(Math.Abs(sum_result), 2), 
                    ProductSquare = Math.Round(product_result * product_result, 2) 
                };

                File.AppendAllLines($"{filename}.txt", new string[]
                {
                    $"модуль суммы: {result.SumModulus}",
                    $"квадрат произведения: {result.ProductSquare}",
                });
                return result;
            }

            public string LabTask2(string rootpath, string pathname)
            {
                var fullname = $"{rootpath}\\{pathname}";
                Directory.CreateDirectory(fullname);

                return fullname;
            }

            public void LabTask3(string filename, FileCreateMethod method, string[] message)
            {
                switch (method)
                {
                case FileCreateMethod.FileWriteAllText: File.WriteAllLines($"{filename}.txt", message); 
                        break;
                case FileCreateMethod.FileCreate:
                    using (var writer = new StreamWriter(File.Create($"{filename}.txt")))
                    {
                        foreach (var line in message) writer.WriteLine(line);
                    }
                    break;
                default: return;
                }
            }

            public string LabTask4(string filename)
            {
                var result = default(string)!;
                using (var reader = new StreamReader(File.OpenRead(filename))) { result = reader.ReadToEnd(); }

                return result;
            }
        }

        private LabLogic LabLogicInstance { get; set; } = default!;

        public Lab8() : base() => this.LabLogicInstance = new();

        public void RunLab()
        {
            var ask = default(int);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания:\n1) - Задание 1\n2) - Задание 2\n" +
                    "3) - Задание 3\n4) - Задание 4\n5) - Завершение работы");

                try { ask = Convert.ToInt32(Console.ReadLine()); }
                catch { continue; }

                switch (ask)
                {
                    case 1: this.Task1(); break;
                    case 2: this.Task2(); break;
                    case 3: this.Task3(); break;
                    case 4: this.Task4(); break;
                    case 5: return;
                    default: continue;
                }
                Console.WriteLine("Нажмите для продолжения");
                Console.ReadKey();
            }
        }

        private void Task1()
        {
            Console.Write("Введите название файла: ");
            var filename = Console.ReadLine()!;

            Console.Write("Введите последовательность чисел: ");
            var numbers_str = Console.ReadLine()!;

            var result = this.LabLogicInstance.LabTask1(filename, numbers_str);
            Console.WriteLine($"Был создан файл {filename}.txt");

            Console.WriteLine($"Модуль суммы: {result.SumModulus}");
            Console.WriteLine($"Квадрат произведения: {result.ProductSquare}");
        }

        private void Task2()
        {
            Console.Write("Путь до корневого каталога: ");
            var rootpath = Console.ReadLine()!;

            Console.Write("Название папки: ");
            var pathname = Console.ReadLine()!;

            try
            {
                Console.WriteLine($"Создана папка: {this.LabLogicInstance.LabTask2(rootpath, pathname)}");
            }
            catch { Console.WriteLine("Невозможно создать папку"); }
        }

        private void Task3()
        {
            Console.Write("Введите название файла: ");
            var filename = Console.ReadLine()!;

            Console.WriteLine("Введите метод создания: (FileCreate, FileWriteAllText)");
            var method = Console.ReadLine()!;

            Console.WriteLine("Введите текст сообщения: ");
            var message_list = new List<string>();
            var current_line = default(string)!;

            while ((current_line = Console.ReadLine()!) != string.Empty) message_list.Add(current_line);
            try
            {
                this.LabLogicInstance.LabTask3(filename, 
                    (LabLogic.FileCreateMethod)Enum.Parse(typeof(LabLogic.FileCreateMethod), method),
                    message_list.ToArray());
            }
            catch { Console.WriteLine("Невозможно записать сообщение в файл"); }
        }

        private void Task4()
        {
            Console.WriteLine("Введите название файла: ");
            var filename = Console.ReadLine()!;

            try
            {
                Console.WriteLine($"Текст сообщения: {this.LabLogicInstance.LabTask4(filename)}");
            }
            catch { Console.WriteLine("Невозможно записать сообщение в файл"); }
        }
    }
}
