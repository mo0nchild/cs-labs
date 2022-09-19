using CSharpLabs.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

            Console.WriteLine("Введите номер задания");
            int ask = default(int) - 1;

            while (ask != 0)
            {
                switch (ask)
                {
                    case 1:
                        Task2();
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
            }
        }

        // -------------------------------------------------| Задание 2 |------------------------------------------------------
        // Среди заданных чисел найти количество трехзначных чисел.
        private static void Task2()
        {
            Console.WriteLine("Введите количество чисел:");
            Console.Clear();

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
        }
    }
}
