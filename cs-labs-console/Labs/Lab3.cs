using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpLabs.Supports;

namespace CSharpLabs.Labs
{
    internal class Lab3 : ILabRunner
    {
        public void Run()
        {
            Task1();
        }
        // -------------------------------------------------| Задание 1 |------------------------------------------------------
        private static void Task1()
        {
            int ask = default(int);
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания\n2) Задание 2\n3) Задание 3\n4) Задание 4\n5) Выход");
                
                try { ask = Convert.ToInt32(Console.ReadLine()); }
                catch { continue; }

                switch (ask)
                {
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:

                        break;
                    case 5:
                        return;
                    default: 
                        continue;
                }
            }

            Console.ReadKey();
        }

        // -------------------------------------------------| Задание 2 |------------------------------------------------------
        // Среди заданных чисел найти количество трехзначных чисел.
        private static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Введите количество чисел:");

            int amount = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите числа");
            double[] input = IOSupport.GetInput(amount);

            int count = default(int);

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().Length == 3)
                {
                    count++;
                }
            }

            if (count == 0) Console.WriteLine("Среди заданных чисел нет трёхзначных");   
            else Console.WriteLine($"Количество чисел удовлетворяющих условие: {count}");

            Console.ReadKey();
        }
        private static void Task3()
        {
            Console.Clear();
            var output = new List<int>();

            for (int i = 1000; i < 9999; i++)
            {
                if (i % 133 == 125 && i % 134 == 111)
                {
                    Console.WriteLine($"Искомые данные: {i}");
                }
            }
            Console.ReadKey();
        }
    }
}
