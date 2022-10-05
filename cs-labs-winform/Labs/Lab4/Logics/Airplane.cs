using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab4.Logics
{
    internal class Airplane : object
    {
        public enum AirplaneType { Millitary, Civil, Sport, Jet, Helicopter }

        private static int current_serial_space = 0;
        private double speed = 0, height = 0;

        public int SerialNumber { get; private set; }
        public double BenzolSpace { get; private set; }
        public double MaxHeight { get; private set; }
        public AirplaneType Type { get; private set; }
        public double MaxSpeed { get; private set; }
        public string Name { get; private set; }

        public Airplane(string name, AirplaneType type, double benzol_space, double max_height, double max_speed)
        {
            this.SerialNumber = current_serial_space++;
            (this.MaxSpeed, this.BenzolSpace, this.MaxHeight) = (max_speed, benzol_space, max_height);
            this.Name = name;
            this.Type = type;
        }

        public Airplane(): this("Ty-134", AirplaneType.Civil, 60, 120, 200) { }

        public string Destroy() => "Plane was destoyed";

        public void HighUp(double delta) 
        {
            if (this.height + delta > this.MaxHeight || this.height + delta < 0) return;
            this.height += delta;
        }

        public void SpeedUp(double delta) 
        {
            if (this.speed + delta > this.MaxSpeed || this.speed + delta < 0) return;
            this.speed += delta;
        }

        public override string ToString() => $"Speed: {speed}, Height: {height}, Name: {Name}";
    }
}
