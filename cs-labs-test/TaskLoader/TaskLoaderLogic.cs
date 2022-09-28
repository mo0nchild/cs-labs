using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;
using System.Security;

namespace CSharpLabs.TaskLoader
{
    public class LabConfigurationAttribute : System.Attribute 
    {
        public readonly string LabName;
        public readonly string TaskName;

        public LabConfigurationAttribute(string labname, string taskname)
        {
            this.LabName = labname;
            this.TaskName = taskname;
        }
    }

    public interface ILabRunner 
    {
        public string TaskInfo { get; }
        public void RunTask(); 
    }

    public class TaskLoaderLogic : object, IEnumerable<(string Name, Dictionary<string, ILabRunner> Tasks)>
    {
        private SortedDictionary<string, List<Type>> LabsList { get; set; } = new();
        public System.UInt32 TasksCount
        {
            get 
            {
                uint tasks_count = default(uint);
                foreach (var lab in this.LabsList) tasks_count += (uint)lab.Value.Count;

                return tasks_count;
            }
        }

        public TaskLoaderLogic(System.Reflection.Assembly assembly)
        {
            foreach (System.Type task_type in assembly.GetTypes()) 
            {
                var attribute = task_type.GetCustomAttribute(typeof(LabConfigurationAttribute));
                if (attribute != null && task_type.GetInterface("ILabRunner") != null) 
                {
                    var configuration = (LabConfigurationAttribute)attribute;
                    if (!this.LabsList.ContainsKey(configuration.LabName)) 
                    {
                        this.LabsList.Add(configuration.LabName, new List<Type> { task_type });
                    }
                    else this.LabsList[configuration.LabName].Add(task_type);
                }
            }
        }
        public TaskLoaderLogic() : this(Assembly.GetExecutingAssembly()) { }

        public string GetTaskInfo(string labname, string taskname) 
        {
            foreach (var task in this.LabsList[labname]) 
            {
                if (task.GetCustomAttribute<LabConfigurationAttribute>()!.TaskName == taskname)
                    return ((ILabRunner?)Activator.CreateInstance(task))!.TaskInfo;
            }
            throw new Exception("Задание не найдено");
        }

        public void InvokeTask(string labname, string taskname)
        {
            this.LabsList[labname].ForEach(delegate (System.Type type)
            {
                var attribute = type.GetCustomAttribute<LabConfigurationAttribute>();
                if (attribute!.TaskName.Equals(taskname))
                {
                    type.GetMethod("RunTask")?.Invoke(Activator.CreateInstance(type), new object[] { });
                }
            });
        }

        public IEnumerator<(string Name, Dictionary<string, ILabRunner> Tasks)> GetEnumerator()
        {
            foreach (var lab in this.LabsList)
            {
                var tasks_list = new Dictionary<string, ILabRunner>();
                for (int i = 0; i < lab.Value.Count; i++) 
                {
                    var attribute = lab.Value[i].GetCustomAttribute<LabConfigurationAttribute>();
                    tasks_list.Add(attribute!.TaskName, (ILabRunner)Activator.CreateInstance(lab.Value[i])!);
                }

                yield return (lab.Key, tasks_list);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
