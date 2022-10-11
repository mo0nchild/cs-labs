using CSharpLabs.Supports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab4", 4)]
    public class Lab4 : ILabRunner
    {
        public void RunLab()
        {
            var task_numer = default(int);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания:\n1) - Задание 1\n2) - Задание 2\n3) - Задание 3\n4) - Задание 4\n5) - Выход");

                try { task_numer = Convert.ToInt32(Console.ReadLine()); }
                catch { continue; }

                switch (task_numer)
                {
                    case 1: this.Task1(); break;
                    case 2: this.Task2(); break;
                    case 3: this.Task3(); break;
                    case 4: this.Task4(); break;
                    default: return;
                }
                Console.WriteLine("Нажмите для продолжения");
                Console.ReadKey();
            }
        }

        private void Task1() 
        {
            int N = (int)default, M = (int)default;

            //Пользовательский ввод
            try
            {
                Console.WriteLine("Введите размерности массива\nN = ");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine("M = ");
                M = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Random rnd = new Random(); // класс отвечающий за генерацию случайных значений

            double[] arrN = new double[N]; // инициализация одномерного массива
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < N; i++)
            {
                double k = Convert.ToDouble(rnd.Next(15));
                //Console.WriteLine($"{k} = случайное значение в одномерном массиве");
                arrN[i] = Math.Round(
                    Math.Sqrt(Convert.ToDouble(N)) * Math.Pow(3.0, k) / Math.Pow(5.0, k), 5);
                Console.WriteLine(arrN[i]);
            }

            double[,] arrNM = new double[N, M];
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    double k = Convert.ToDouble(rnd.Next(15));
                    //Console.WriteLine($"{k} = случайное значение в двумерном массиве");
                    arrNM[i, j] = Math.Round(
                        Math.Sqrt(Convert.ToDouble(N)) * Math.Pow(3.0, k) / Math.Pow(5.0, k), 5);
                    Console.Write($"{arrNM[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        private void Task2()
        {
            const int size = 10;
            
            Random rnd = new Random();
            
            int[] arrA = new int[size];
            int[] arrB = new int[size];

            for (int i = 0; i < size; i++)
            {
                arrA[i] = rnd.Next(100);

                arrB[i] = rnd.Next(100);
            }

            Console.WriteLine($"{arrA[0]} != {arrB[0]}");

            Console.WriteLine("Массив А до изменений:\t\tМассив B до изменений:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arrA[i]}\t\t\t\t{arrB[i]}\n");
            }
            Console.WriteLine();

            int max = default;

            if (arrB.Max() > arrA.Max())
            {
                max = arrB.Max();
                Console.WriteLine($"Элемент с максимальным значением находится в массиве В {max}\n");
            }
            else
            {
                max = arrA.Max();
                Console.WriteLine($"Элемент с максимальным значением находится в массиве А: {max}\n");
            }

            for (int i = 0; i < size; i++) { arrA[i] -= max; arrB[i] -= max; }

            Console.WriteLine("Массив А после изменений:\tМассив B после изменений:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arrA[i]}\t\t\t\t{arrB[i]}\n");
            }
            Console.WriteLine();
        }
        private void Task3()
        {
            Console.WriteLine("Введите число n (размер матрицы): ");

            int n = default(int);
            try { n = int.Parse(Console.ReadLine()!); }
            catch { Console.WriteLine("Неверное значение n"); return; }

            double[,] matrix = new double[n, n];
            for (var y = 0; y < n; y++) 
            {
                Console.Write("Введите значение для {0} строки: ", y + 1);
                string[] row = Console.ReadLine()!.Split(' ');

                for (var x = 0; x < row.Length; x++) 
                {
                    try { matrix[x, y] = double.Parse(row[x]); }
                    catch { continue; }
                }

            }

            double summary = default(double);
            for (var i = 0; i < Math.Pow(n, 2); i++) 
            {
                int y = (i / n), x = i - y * n;
                if (x > n - y - 1) summary += (matrix[x, y]);
            }
            Console.WriteLine("Сумма значений = {0}", summary);

        }
        private void Task4()
        {
            Console.Write("Введите значениям элементам: ");
            string[] input_strings = Console.ReadLine()!.Split(' ');

            double[] arr = new double[input_strings.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                try { arr[i] = double.Parse(input_strings[i]); } catch { continue; }
            }

            foreach (var i in MergingSort(arr.Split(), arr.Split(true))) Console.Write("{0}, ", i);
            Console.WriteLine();
            
            double[] MergingSort(double[] left, double[] right)
            {
                double[] left_result = (left.Length > 1) ? MergingSort(left.Split(), left.Split(true)) : left, 
                    right_result = (right.Length > 1) ? MergingSort(right.Split(), right.Split(true))  : right, 
                    result = new double[left.Length + right.Length];

                int left_cursor = 0, right_cursor = 0, i = 0;
                while (left_cursor != left_result.Length || right_cursor != right_result.Length)
                {
                    if (left_cursor >= left_result.Length || right_cursor >= right_result.Length)
                    {
                        if (left_cursor == left_result.Length) result[i++] = right_result[right_cursor++];
                        else result[i++] = left_result[left_cursor++];

                        continue;
                    }

                    result[i++] = (left_result[left_cursor] < right_result[right_cursor])
                        ? left_result[left_cursor++]
                        : right_result[right_cursor++];
                }
                return result;
            }
        }
    }
}
