using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab11.Logics
{
    internal class Person : User
    {
        public enum GenderType { Man, Woman }

        public System.String FIO { get; set; } = default!;
        public System.DateTime Birthday { get; set; } = default;
        public GenderType Gender { get; set; } = default;

        public Person(string login, string password) : base(login, password) { }

        public override string? Authorization(string login, string password)
        {
            if (base.Password != password || base.Login != login) return default;
            return this.ToString();
        }

        public override string ToString() => $"ФИО: {this.FIO},\r\nДата рождения: {this.Birthday.ToString()},\r\n" +
            $"Пол: {this.Gender.ToString()}";
    }
}
