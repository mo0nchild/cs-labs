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
    [TaskLoader.LabConfiguration("Lab1", "Task1")]
    public partial class Task1 : Form, ILabRunner
    {
        public string TaskInfo => "Task1 Lab1 Info";
        public Task1() => InitializeComponent();

        public void RunTask() => this.ShowDialog();
    }
}
