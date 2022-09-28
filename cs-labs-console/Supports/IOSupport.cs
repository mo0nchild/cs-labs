using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Supports
{
    public static class IOSupport
    {
        // функция для последовательного ввода и чтения значений через символ пробела
        public static double[] GetInput(int n)
        {
            // чтение строки, и преобразование в массив отдельных значений (используя для деления знак пробела)
            var input_array = Console.ReadLine()!.Split(' ');
            var input_values = new double[n];
            try // трансформация каждого элемента массива строк в значения для массива вещественных данных
            {
                for (int i = 0; i < n; i++) input_values[i] = double.Parse(input_array[i]);
            }
            catch (FormatException error) { Console.WriteLine(error.Message); }
            return input_values;
        }
    }
}
