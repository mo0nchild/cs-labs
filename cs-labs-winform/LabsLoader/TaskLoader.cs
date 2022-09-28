using CSharpLabs.Supports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs.LabsLoader
{
    [type: System.AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TaskDetectAttribute : System.Attribute
    {
        public System.String TaskName { get; private set; }
        public System.String LabName { get; private set; }
        public TaskDetectAttribute(string task_name, string lab_name) => (TaskName, LabName) = (task_name, lab_name);
    }

    public class TaskComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x is null || y is null) return default(int);
            return x.CompareTo(y);
        }
    }

    public interface ITaskLaunchable 
    { 
        public string TaskInfo { get; }
        public void TaskLaunch(); 
    }

    public class TaskLoader : object, IEnumerable<System.String>
    {
        public readonly System.String LabName = string.Empty;
        public readonly System.Int32 LabNumber = default(int);

        public SortedDictionary<string, Type> Tasks { get; private set; } = new(new TaskComparer());

        public TaskLoader(Assembly assembly, Type lab_type)
        {
            var lab_attribute = lab_type.GetCustomAttribute<LabDetectAttribute>()!;

            this.LabName = lab_attribute.LabName;
            this.LabNumber = lab_attribute.LabNumber;

            foreach (var type in assembly.GetTypes())
            {
                var attribute = (TaskDetectAttribute?) type.GetCustomAttribute(typeof(TaskDetectAttribute));
                if (attribute != null && type.GetInterface("ITaskLaunchable") != null) 
                {
                    if (attribute.LabName != this.LabName) continue;
                    this.Tasks.Add(attribute.TaskName, type);
                }
            }
        }
        public TaskLoader(Type lab_type) : this(Assembly.GetExecutingAssembly(), lab_type) { }

        public string GetTaskInfo(string task_name)
        {
            var task = (ITaskLaunchable)Activator.CreateInstance(this.Tasks[task_name])!;
            return task.TaskInfo;
        }

        public void LaunchTask(string task_name)
        {
            object? task = Activator.CreateInstance(this.Tasks[task_name]);
            this.Tasks[task_name]?.GetMethod("TaskLaunch")?.Invoke(task, new object[] { });
        }

        public IEnumerator<System.String> GetEnumerator()
        {
            foreach (KeyValuePair<string, Type> item in this.Tasks) yield return item.Key;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
