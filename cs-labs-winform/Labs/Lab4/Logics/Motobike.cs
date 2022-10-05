using CSharpLabs.Lab2.Logics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab4.Logics
{
    internal class Motobike: object
    {
        public enum MotoType { Scooter, Classic, Sports, Tourer }
        private static int CurrentServiceNumber = 0;

        public double Speed { get; private set; } = 0;
        public int ServiceNumber { get; private set; }
        public MotoType Type { get; private set; }
        public double MaxSpeed { get; set; }


        public Motobike(double maxspeed, MotoType type)
        {
            MaxSpeed = maxspeed;
            ServiceNumber = CurrentServiceNumber++;
            Type = type;
        }

        public Motobike() : this(100, MotoType.Classic) { }

        public void SpeedUp(double speed)
        {
            if (Speed + speed > MaxSpeed || Speed + speed < 0) Console.WriteLine("Неверное значение");
            else
            {
                Speed += speed;
                Console.WriteLine("Текущая скорость = " + Speed);
            }
        }

        public override string ToString() => $"Скорость: {Speed}, Максимальная скорость: {MaxSpeed}, Тип: {Type.ToString()}, " +
            $"Сервисный номер: {ServiceNumber}";
    }
}
