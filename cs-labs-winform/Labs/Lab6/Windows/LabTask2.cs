using CSharpLabs.LabsLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabs.Lab6.Windows
{
    [TaskDetectAttribute("Задание 2", "WinformLab6")]
    public partial class LabTask2 : Form, ITaskLaunchable
    {
        public LabTask2()
        {
            InitializeComponent();
        }

        public string TaskInfo => "Создать разнородную (элементом является объект заданного класса) коллекцию объектов List<T>.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
