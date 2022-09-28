using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpLabs.Supports;

namespace CSharpLabs.Labs
{
    [type: LabDetectAttribute("ConsoleLab1", 1)]
    internal class Lab1 : ILabRunner
    {
        //public string LabName => "ConsoleLab1";
        // -------------------------------------------------| Задание 1 |------------------------------------------------------
        private static void Task1()
        {
            // подзадание 1: даны x, y, z, вычислить a, b, по формуле
            Console.Write("\n1) Введите строку значений (x y z): ");
            double[] input_1 = IOSupport.GetInput(3);
            CalculateAB(input_1[0], input_1[1], input_1[2]);

            // подзадание 2: Вычислить время падения тела с высоты h с начальной скоростью _v
            Console.Write("\n2) Введите строку значений (H V): ");
            double[] input_2 = IOSupport.GetInput(2);
            Console.Write("Falling time: {0}\n", CalculateTime(input_2[0], input_2[1]));

            // подзадание 3: определить, имеет ли квадратное уравнение с коэффициентами a, b и c решение
            Console.Write("\n3) Введите строку значений (a b c): ");
            double[] inpute_3 = IOSupport.GetInput(3);
            Console.Write((CalculateTruth(inpute_3[0], inpute_3[1], inpute_3[2]) ? "Возможно" : "Невозможно") + " решить уравнение\n");

            // подзадание 4: Составить программу вычисления площадей различных геометрических фигур
            Console.Write("\n4) Введите строку значений (a b h R): ");
            double[] inpute_4 = IOSupport.GetInput(4);
            for (int i = 0; i < 6; i++) Console.WriteLine($"S = {CalculateArea(inpute_4[0], inpute_4[1], inpute_4[2], i, inpute_4[3])}, n = {i}");

            // локальная функция (метод) для расчета значений А и Б
            void CalculateAB(double x, double y, double z)
            {
                double a = y + x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 2)))),
                    b = Math.Pow(1 + Math.Pow(Math.Tan(z / 2), 2), 2);

                Console.WriteLine($"Результат - A: {a}, B: {b}\n");
            }

            // локальная функция (метод) для вычисления времени падения объекта
            double CalculateTime(double h, double _v) => (Math.Sqrt(2 * 10.0 * h + Math.Pow(_v, 2)) - _v) / 10.0;

            // локальная функция (метод) для проверки условия способности решения квадратного уравления 
            bool CalculateTruth(double a, double b, double c) => Math.Pow(b, 2) - 4.0 * a * c >= 0;

            // локальная функция (метод) для расчета площади выбранной фигуры n
            double CalculateArea(double a, double b, double h, int n, double R)
            {
                switch (n)
                {
                    case 1: return a * b;
                    case 2: return a * h / 2;
                    case 3: return (a + b) * h / 2;
                    case 4: return Math.PI * Math.Pow(R, 2);
                    case 5: return Math.PI * Math.Pow(R, 2) * a / 360.0;
                    default:
                        Console.WriteLine("Введено недопустимое значение n\n");
                        return 0;
                }
            }
        }

        // --------------------------------------------------------------------------------------------------------------------

        // -------------------------------------------------| Задание 2 |------------------------------------------------------

        // перечисление используемое для определения типа мотоцикла (скутер, классический, спортивный, туристический)
        private enum MotoType { Scooter = 1, Classic, Sports, Tourer }
        // определение структуры для описания сущности мотоцикла
        private struct MotoBike
        {
            // неизменяемое поле, которое определяет стандартное значение скорости мотоцикла
            private const double StandantSpeed = 101.0;
            // статическое поле используемое для определения серийного номера мотоцикла
            private static int CurrentServiceNumber = 0;

            public double Speed { get; private set; } = 0; // текущая скорость мотоцикла
            public int ServiceNumber { get; private set; } // серийный номер
            public MotoType Type { get; private set; } // тип транспорта
            public double MaxSpeed { get; set; } // максимальная заявленная скорость

            // специальный конструктор, который позволяет установить значения максивальной скорости и типа мотоцикла
            public MotoBike(double maxspeed, MotoType type)
            {
                MaxSpeed = maxspeed;
                ServiceNumber = CurrentServiceNumber++;
                Type = type;
            }

            // стандартный конструктор, который использует значение конст поля при передачи управления специальному
            public MotoBike() : this(StandantSpeed, MotoType.Classic) { }

            // метод для управления скоростью транпорта (положительное значение - разгон, отрицательное - торможение)
            public void SpeedUp(double speed)
            {
                if (Speed + speed > MaxSpeed || Speed + speed < 0) Console.WriteLine("Неверное значение");
                else
                {
                    Speed += speed;
                    Console.WriteLine("Текущая скорость = " + Speed);
                }
            }

            // метод, позволяющий вывести текущее состояние экземпляра мотоцикла
            public string GetState() => $"Скорость: {Speed}, Максимальная скорость: {MaxSpeed}, Тип: {Type.ToString()}, " +
                $"Сервисный номер: {ServiceNumber}";

            // переопределение метода Object.ToString
            public override string ToString() => GetState();
        }

        private static void Task2()
        {
            Console.WriteLine("Создание нового объекта структуры \"Мотоцикл\"");
            // вызов функции для конфигурации и создания начального объекта мотоцикла
            MotoBike motobike_object = CreateMotoBike();

            while (true)
            {
                Console.Write("\n1) - Получение текущего состояния; 2) - Изменение скорости; 3) - Создать новый; 4) - Выход\n" +
                    "Введите номер операции: ");
                int input_value = default;

                // обработка пользовательского ввода с целью определения типа операции над объетом
                try { input_value = int.Parse(Console.ReadLine()!); }
                catch (FormatException error) { Console.WriteLine(error.Message); return; }

                switch (input_value)
                {
                    // вывод текущего установленного состояния экземляра
                    case 1: Console.WriteLine(motobike_object.GetState()); break;
                    case 2:
                        {
                            Console.Write("Введите значение: ");
                            double delta_speed = default;

                            // установка величины, на которую будет изменена скорость мотоцикла 
                            try { delta_speed = double.Parse(Console.ReadLine()!); }
                            catch (FormatException error) { Console.WriteLine(error.Message); return; }

                            // изменение скорости транспорта
                            motobike_object.SpeedUp(delta_speed);
                            break;
                        }
                    // процесс создания и настройки нового объекта мотоцикла
                    case 3: motobike_object = CreateMotoBike(); break;
                    case 4: return;
                    default: Console.WriteLine("Указано неверное значение"); break;
                }
            }

            MotoBike CreateMotoBike()
            {
                try
                {
                    // определение типа мотоцикла, относительно пользователького ввода
                    Console.WriteLine("Выберите тип мотоцикла: { 1 - Скутер, 2 - Классический, 3 - Спортивный, 4 - Турист. }");
                    var moto_type = (MotoType)Enum.Parse(typeof(MotoType), Console.ReadLine()!);

                    // установка значения максимальной скорости новой модели мотоцикла
                    Console.WriteLine("Установите максимальную скорость мотоцикла:");
                    var moto_maxspeed = long.Parse(Console.ReadLine()!);

                    if (moto_maxspeed <= 0) // проверка валидности переданного значения
                    {
                        throw new Exception("Установите нормальное значение скорости (>_<)");
                    }
                    return new MotoBike(moto_maxspeed, moto_type); // возвращение созданной модели мотоцикла
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message + ";");
                    return new MotoBike();
                }
            }
        }

        public void RunLab()
        {
            while (true)
            {
                Console.WriteLine("Что необходимо выполнить?\n1) - Задание 1\n2) - Задание 2\n3) - Завершение программы\n");
                int input_value = default;

                // обработка пользовательского ввода для установки значения операции
                try { input_value = int.Parse(Console.ReadLine()!); }
                catch (FormatException error) { Console.WriteLine(error.Message); return; }

                // выбор необходимого задания лабораторной работы
                switch (input_value)
                {
                    case 1: Task1(); break; // задание 1
                    case 2: Task2(); break; // задание 2
                    case 3: return;
                    default: Console.WriteLine("Указано неверное значение"); break;
                }
                Console.WriteLine("Нажмите клавишу для продолжения");
                Console.ReadKey(); // ожидание пользователя
                Console.Clear(); // очистка буфера консоли
            }
        }
    }
}
