using System;
using System.Collections.Generic;
using System.Reflection;
using CSharpLabs.Labs;

namespace CSharpLabs
{
    public interface ILabRunner { void Run(); }

    public class Program
    {
        public List<Type> GetLabsTypes() 
        {
            var list = new List<System.Type>();
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetInterface("ILabRunner", true) != null) list.Add(type);
            }
            return list;
        }

        public static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.Write($"Выберите необходимую лабораторную работу (1-): ");
            }
        }
    }
}
