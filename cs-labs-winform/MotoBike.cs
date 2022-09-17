using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_labs_winform
{
    // перечисление используемое для определения типа мотоцикла (скутер, классический, спортивный, туристический)
    internal class Logic
    {
        private enum MotoType { Scooter = 1, Classic, Sports, Tourer }
        private struct MotoBike
        {
            // неизменяемое поле, которое определяет стандартное значение скорости мотоцикла
            private const double StandantSpeed = 101.0;
            // статическое поле используемое для определения серийного номера мотоцикла
            private static int CurrentServiceNumber = 0;

            public double Speed { get; set; } = 0; // текущая скорость мотоцикла
            public int ServiceNumber { get; private set; } // серийный номер
            public MotoType Type { get; private set; } // тип транспорта
            public double MaxSpeed { get; set; } // максимальная заявленная скорость

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
                if (Speed + speed > MaxSpeed || Speed + speed < 0) MessageBox.Show("Неверное значение");
                else
                {
                    this.Speed += speed;
                    MessageBox.Show("Текущая скорость = " + Speed);
                }
            }

            // метод, позволяющий вывести текущее состояние экземпляра мотоцикла
            public string GetState() => $"Скорость: {Speed}, Максимальная скорость: {MaxSpeed}, Тип: {Type.ToString()}, " +
                $"Сервисный номер: {ServiceNumber}";

            // переопределение метода Object.ToString
            public override string ToString() => this.GetState();
        }
    }
}
