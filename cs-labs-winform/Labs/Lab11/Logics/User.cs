using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab11.Logics
{
    internal abstract class User : System.Object
    {
        public System.String Login { get; private set; } = default!;
        public System.String Password { get; private set; } = default!;
        protected System.Guid Key { get; private set; } = default;

        public User(string login, string password) : base()
        {
            this.Login = login; this.Password = password;
            this.Key = Guid.NewGuid();
        }

        public abstract string? Authorization(string login, string password);
    }
}
