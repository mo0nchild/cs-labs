using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab6.Logic
{
    internal class Motobike : System.Object
    {
        public enum MotoType { Scooter = 1, Classic, Sports, Tourer }

        private const double StandantSpeed = 101.0;

        private static int CurrentServiceNumber = 0;

        public double Speed { get; private set; } = 0;
        public string Name { get; set; } = "";
        public int ServiceNumber { get; private set; }
        public MotoType Type { get; private set; }
        public double MaxSpeed { get; set; }

        public Motobike(double maxspeed, MotoType type)
        {
            MaxSpeed = maxspeed;
            ServiceNumber = CurrentServiceNumber++;
            Type = type;
        }

        public Motobike() : this(StandantSpeed, MotoType.Classic) { }

        public void SpeedUp(double speed)
        {
            if (Speed + speed > MaxSpeed || Speed + speed < 0) Console.WriteLine("Неверное значение");
            else
            {
                Speed += speed;
                Console.WriteLine("Текущая скорость = " + Speed);
            }
        }

        public string GetState() => $"Скорость: {Speed}, Максимальная скорость: {MaxSpeed}, Тип: {Type.ToString()}, " +
            $"Сервисный номер: {ServiceNumber}";


        public override string ToString() => GetState();
        
    }
}
