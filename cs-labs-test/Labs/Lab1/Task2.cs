using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.TaskLoader;

namespace CSharpLabs.Labs.Lab1
{
    [type: TaskLoader.LabConfiguration("Lab1", "Task2")]
    public partial class Task2 : Form, ILabRunner
    {
        public string TaskInfo => "Task2 Lab1 Info";
        public Task2() => InitializeComponent();
        public void RunTask() => this.ShowDialog();
    }
}
