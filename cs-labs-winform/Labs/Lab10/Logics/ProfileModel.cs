using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Lab10.Logics
{
    [SerializableAttribute]
    public class ProfileModel : System.Object
    {
        public enum GenderType { Men, Woman }

        public string FIO { get; set; } = "";
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public DateTime Birthday { get; set; }
        public GenderType Gender { get; set; }
        public string Faculty { get; set; } = "";
        public string Post { get; set; } = "";
        public System.Guid Key { get; private set; } = default;

        public ProfileModel() : base() => this.Key = Guid.NewGuid();

        public override bool Equals(object? obj)
        {
            if (obj is ProfileModel profile)
            {
                return (this.Login == profile.Login 
                    && this.Password == profile.Password );
            }
            return false;
        }

        public override int GetHashCode() => FIO.GetHashCode();
    }
}
