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
    [type: LabDetectAttribute("ConsoleLab5", 5)]
    public class Lab5 : ILabRunner
    {
        public class LabLogic: object
        {
            public delegate void MessageError(string msg);
            public MessageError? message = default(MessageError);

            public void RegisterDeligate(MessageError message) => this.message = message;

            public string Task1(string str)
            {
                try
                {
                    string str_Temp = "";

                    char buff_end = str[str.Length - 1];
                    char buff_begin = str[0];

                    str_Temp = Convert.ToString(buff_end);
                    str_Temp += str.Substring(1, str.Length - 2);
                    str_Temp += Convert.ToString(buff_begin);

                    return str_Temp;
                }
                catch (Exception except) { message?.Invoke(except.Message); return ""; }
            }

            public List<string>? Task2(string str)
            {
                try
                {
                    str = str.TrimEnd('.');
                    List<string> list = new List<string>();
                    var temp = str.Split(',');

                    for (int i = 0; i < temp.Count(); i++) temp[i] = temp[i].Replace(" ", "");

                    for (int i = 0; i < temp.Length; i++)
                    {
                        string buff = temp[i].ToLower();
                        int count = 0;
                        for (int j = 0; j < temp.Length; j++)
                        {
                            if (count >= 2)
                            {
                                list.Add(temp[i].ToLower());
                            }
                            if (buff.ToLower().Equals(temp[j].ToLower())) count++;
                        }
                    }
                    return list.Distinct().ToList();
                }
                catch (Exception except) { message?.Invoke(except.Message); return null; }
            }

            public string? Task3(string str, string lenguage)
            {
                try
                {
                    switch (lenguage)
                    {
                        case "Rus":
                            return Regex.Replace(str, "[АаИиОоУуЫыЭэЕеЁёЮюЯя]", "");
                        case "Eng":
                            return Regex.Replace(str, "[aAeEiIoOUuYy]", "");
                        default:
                            message?.Invoke("Некорректный язык");
                            return null;
                    }
                }
                catch (Exception except) { message?.Invoke(except.Message); return null; }
            }
        }

        private LabLogic labLogic = new();

        public Lab5() => this.labLogic.RegisterDeligate((string str)=>Console.WriteLine(str));

        public void RunLab()
        {
            var ask = default(int);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания:\n1) - Задание 1\n2) - Задание 2\n3) - Задание 3\n4) - Завершение работы");

                try { ask = Convert.ToInt32(Console.ReadLine()); }
                catch { continue; }

                switch (ask)
                {
                    case 1: this.Task1(); break;
                    case 2: this.Task2(); break;
                    case 3: this.Task3(); break;
                    case 4: return; 
                    default: continue;
                }
                Console.WriteLine("Нажмите для продолжения");
                Console.ReadKey();
            }
        }

        private void Task1() 
        {
            Console.Clear();
            Console.Write("Введите строку на обработку: ");
            
            string str = this.labLogic.Task1(Console.ReadLine()!);
            Console.WriteLine($"Результат: {str}");
        }

        private void Task2()
        {
            Console.Clear();
            Console.Write("Введите строку на обработку: ");

            List<string>? list = this.labLogic.Task2(Console.ReadLine()!);
            if (list == null) return;

            Console.WriteLine($"Результат: ");
            foreach (var str in list) 
            {
                Console.WriteLine($"\t{list}");
            }

        }

        private void Task3()
        {
            Console.Clear();
            Console.Write("Введите строку на обработку: ");
            string input_value = Console.ReadLine()!;

            Console.Write("Введите язык обработки (Rus|Eng): ");
            string input_lang = Console.ReadLine()!;

            string? str = this.labLogic.Task3(input_value, input_lang);
            if (str == null) return;
            Console.WriteLine($"Результат: {str}");
        }
    }
}
