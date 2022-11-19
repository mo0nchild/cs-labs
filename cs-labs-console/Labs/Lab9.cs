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
using System.Net.Http.Headers;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab9", 9)]
    public class Lab9 : ILabRunner
    {
        public struct ResultData
        {
            public double SumModulus { get; set; }
            public double ProductSquare { get; set; }
        }

        public struct FileInfoData
        {
            public string CreateTime { get; set; }
            public string LastAccess { get; set; }
            public string LastWrite { get; set; }
        }

        public sealed class Lab9Logic : System.Object
        {
            public string FileName { get => "file.txt"; }

            public int[] ReadValues()
            {
                var result_list = new List<int>();
                using (var reader = new BinaryReader(File.OpenRead(this.FileName)))
                {
                    while(reader.PeekChar() != -1) result_list.Add(reader.ReadInt32());
                }
                return result_list.ToArray();
            }

            public ResultData LabTask2(int[] values, int offset, int @new)
            {
                using (var binary_writer = new BinaryWriter(File.Create(this.FileName)))
                {
                    foreach (var item in values) binary_writer.Write(item);
                    binary_writer.Seek(offset * sizeof(int), SeekOrigin.Begin);
                    binary_writer.Write(@new);
                }
                using (var binary_reader = new BinaryReader(File.OpenRead(this.FileName)))
                {
                    var result = new ResultData { ProductSquare = 1, SumModulus = 0 };
                    while (binary_reader.PeekChar() != -1)
                    {
                        var read_value = binary_reader.ReadInt32();

                        result.ProductSquare *= read_value;
                        result.SumModulus += read_value;
                    }
                    return new ResultData { SumModulus = Math.Abs(result.SumModulus), 
                        ProductSquare = Math.Pow(result.ProductSquare, 2)
                    };
                }
            }

            public FileInfoData LabTask4(string filepath)
            {
                if (!File.Exists(filepath)) throw new Exception("Файл не найден");

                var fileinfo = new FileInfo(filepath);
                return new FileInfoData
                {
                    CreateTime = fileinfo.CreationTime.ToString(),
                    LastAccess = fileinfo.LastAccessTime.ToString(),
                    LastWrite = fileinfo.LastWriteTime.ToString()
                };
            }
        }

        private Lab9Logic LabLogic { get; set; } = default!;
        public Lab9() : base() => this.LabLogic = new Lab9Logic();

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
            
        }

        private void Task2()
        {
            var input_numbers = new List<int>();
            var input_string = default(string)!;

            Console.WriteLine("Введите последовательность чисел:");
            while (true)
            {
                input_string = Console.ReadLine()!;
                if (input_string == String.Empty) break;

                try { input_numbers.Add(Convert.ToInt32(input_string)); }
                catch (System.Exception) { continue; }
            }
            int offset = default(int), new_value = default(int);

            Console.Write("Введите значение (смещение;новое число):");
            input_string = Console.ReadLine()!;
            try {
                var input_values = input_string.Split(';');
                offset = int.Parse(input_values[0]);
                new_value = int.Parse(input_values[1]);
            }
            catch (System.Exception) { Console.WriteLine("Невозможно прочитать смещение"); return; }
            var task_result = LabLogic.LabTask2(input_numbers.ToArray(), offset, new_value);

            Console.WriteLine($"Модуль суммы: {task_result.SumModulus}, " +
                $"Квадрат произведения: {task_result.ProductSquare}");
        }

        private void Task3()
        {
            
        }

        private void Task4()
        {
            Console.Write("Введите путь к файлу: ");
            var taskresult = LabLogic.LabTask4(Console.ReadLine()!);
            
            foreach(var property in typeof(FileInfoData).GetProperties())
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(taskresult)}");
            }
        }
    }
}
