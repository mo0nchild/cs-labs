using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.Supports
{
    public interface ILabRunner { void Run(); }

    public static class LabsLoaderSupport
    {
        public static List<Type> GetLabsTypes()
        {
            var list = new List<System.Type>();
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface("ILabRunner", true) != null) list.Add(type);
            }
            return list;
        }

    }
}
