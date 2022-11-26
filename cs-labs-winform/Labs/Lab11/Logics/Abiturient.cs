using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab11.Logics
{
    internal class Abiturient : Person
    {
        public System.String Certificate { get; set; } = default;
        public System.Int32 ScoreCount { get; set; } = default!;

        public Abiturient(string login, string password) : base(login, password) { }

        public override string? Authorization(string login, string password)
        {
            if (base.Password != password || base.Login != login) return default;
            return this.ToString();
        }

        public override string ToString() => $"Аттестат: {Certificate},\r\nРейтинг: {ScoreCount},\r\n"
            + base.ToString();
    }
}
