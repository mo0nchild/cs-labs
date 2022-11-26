using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab11.Logics
{
    internal class Employee : Person
    {
        public System.String Post { get; set; } = default!;
        public System.String Faculty { get; set; } = default!;

        public Employee(string login, string password) : base(login, password) { }

        public override string? Authorization(string login, string password)
        {
            if (base.Password != password || base.Login != login) return default;
            return this.ToString();
        }

        public override string ToString() => $"Должность: {this.Post},\r\nФакультеты: {this.Faculty},\r\n"
            + base.ToString();
    }
}
