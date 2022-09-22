using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab2.Logics
{
    // перечисление используемое для определения типа мотоцикла (скутер, классический, спортивный, туристический)
    public enum MotoType { Scooter = 1, Classic, Sports, Tourer }
    public struct MotoBike
    {
        // неизменяемое поле, которое определяет стандартное значение скорости мотоцикла
        private const double StandantSpeed = 101.0;
        // статическое поле используемое для определения серийного номера мотоцикла
        private static int CurrentServiceNumber = 0;

        public double Speed { get; private set; } = 0; // текущая скорость мотоцикла
        public int ServiceNumber { get; private set; } // серийный номер
        public MotoType Type { get; private set; } // тип транспорта
        public double MaxSpeed { get; private set; } // максимальная заявленная скорость

        // специальный конструктор, который позволяет установить значения максивальной скорости и типа мотоцикла
        public MotoBike(double maxspeed, MotoType type)
        {
            this.MaxSpeed = maxspeed;
            this.ServiceNumber = CurrentServiceNumber++;
            this.Type = type;
        }

        // стандартный конструктор, который использует значение конст поля при передачи управления специальному
        public MotoBike() : this(StandantSpeed, MotoType.Classic) { }

        // метод для управления скоростью транпорта (положительное значение - разгон, отрицательное - торможение)
        public void SpeedUp(double speed)
        {
            if (Speed + speed > MaxSpeed || Speed + speed < 0) throw new Exception("Неверное значение");
            this.Speed += speed;
        }

        // метод, позволяющий вывести текущее состояние экземпляра мотоцикла
        public string GetState() => $"Скорость: {Speed}, Максимальная скорость: {MaxSpeed}, " +
            $"Тип: {Type.ToString()}, Сервисный номер: {ServiceNumber}";

        // переопределение метода Object.ToString
        public override string ToString() => this.GetState();
    }
}
