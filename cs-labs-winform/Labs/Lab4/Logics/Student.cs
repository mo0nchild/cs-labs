using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab4.Logics
{
    internal class Student: object
    {
        private static int id = 0;

        public bool Grant { get; private set; }
        public int Id { get { return id; } }
        public double Gpa { get; private set; }
        public string Group { get; private set; }
        public string Name { get; private set; }

        public Student(bool grant, float gpa, string group, string name)
        {
            this.Grant = grant;
            this.Gpa = gpa;
            this.Group = group;
            this.Name = name;
            id++;
        }

        public Student()
        {
            this.Grant = true;
            this.Gpa = 4.6;
            this.Group = "БТР-224";
            this.Name = "Роман";
            id++;
        }
        public string Scholarship()
        {
            if (Grant) return (Gpa * 1000).ToString();
            else return "У данного студента нет стипендии";
        }

        public double Study(double delta)
        {
            if (Gpa + delta > 5) return 5;
            return Gpa + delta;
        }

        public override string ToString() => $"Студент: {Name}, группа: {Group}, " +
            $"номер: {Id}, средний бал: {Gpa}, стипендия: {Scholarship()}";
    }
}
