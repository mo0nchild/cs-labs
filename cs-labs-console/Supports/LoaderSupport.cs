using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLabs.Supports
{
    [System.AttributeUsage(AttributeTargets.Class)]
    public class LabDetectAttribute : System.Attribute 
    {
        public string LabName { get; set; }
        public int LabNumber { get; set; }
        public LabDetectAttribute(string lab_name, int lab_number) => (this.LabName, this.LabNumber) = (lab_name, lab_number);
    }

    public class LabComparer : IComparer<System.Type>
    {
        public int Compare(Type? x, Type? y)
        {
            if (x is null || y is null) throw new Exception("Недопустимое значение аргументов");
            var x_attribute = x.GetCustomAttribute<LabDetectAttribute>()!;
            var y_attribute = y.GetCustomAttribute<LabDetectAttribute>()!;

            return string.Compare(x_attribute.LabName, y_attribute.LabName);
        }
    }
    public interface ILabRunner { void RunLab(); }
    public class LoaderSupport : System.Object, IEnumerable<(System.Type Type, string Name)>
    {
        private SortedSet<System.Type> TypesList { get; set; } = new(new LabComparer());
        public int TypesListCount { get => this.TypesList.Count; }
        public (System.Type Type, string Name) this[int key]
        {
            get => (this.TypesList.ElementAt(key),
                this.TypesList.ElementAt<Type>(key).GetCustomAttribute<LabDetectAttribute>()!.LabName);
        }
        public LoaderSupport() : this(Assembly.GetExecutingAssembly()) { }
        public LoaderSupport(Assembly assembly) 
        {
            foreach (System.Type labtype in assembly.GetTypes())
            {
                if (labtype.GetCustomAttribute(typeof(LabDetectAttribute)) != null
                    && labtype.GetInterface("ILabRunner", true) != null) this.TypesList.Add(labtype);
            }
        }
        public void InvokeTask(int task_index = 0) 
        {
            System.Type labtype = this.TypesList.ElementAt(task_index);
            try 
            {
                object? lab_instance = Activator.CreateInstance(labtype);
                labtype.GetMethod("RunLab")?.Invoke(lab_instance, new object[] { });
            }
            catch(System.Exception error) { Console.WriteLine($"{labtype}: {error.Message}"); }
        }
        public IEnumerator<(System.Type Type, string Name)> GetEnumerator()
        {
            foreach (System.Type labtype in this.TypesList)
            {
                yield return (labtype, labtype.GetCustomAttribute<LabDetectAttribute>()!.LabName);
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => (IEnumerator)this.GetEnumerator();
    }
}
