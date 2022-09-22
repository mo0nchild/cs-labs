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
    public interface ILabRunner 
    { 
        public string LabName { get; }
        public void RunLab(); 
    }

    public class LoaderSupport : System.Object, IEnumerable<(System.Type Type, string Name)>
    {
        private List<System.Type> TypesList { get; set; } = new();
        public int TypesListCount { get => this.TypesList.Count; }

        public (System.Type Type, string Name) this[int index]
        {
            get => (this.TypesList[index], ((ILabRunner)Activator.CreateInstance(this.TypesList[index])!).LabName);
        }

        public LoaderSupport() : this(Assembly.GetExecutingAssembly()) { }
        public LoaderSupport(Assembly assembly) 
        {
            foreach (System.Type labtype in assembly.GetTypes())
            {
                if (labtype.GetInterface("ILabRunner", true) != null) this.TypesList.Add(labtype);
            }
        }

        public void InvokeTask(int task_index = 0) 
        {
            System.Type labtype = this.TypesList[task_index];
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
                yield return (labtype, ((ILabRunner)Activator.CreateInstance(labtype)!).LabName);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
