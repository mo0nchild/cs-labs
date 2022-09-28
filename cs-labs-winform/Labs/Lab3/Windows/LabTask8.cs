using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.Lab3.Logics;
using CSharpLabs.LabsLoader;

namespace CSharpLabs.Lab3.Windows
{
    [type: TaskDetectAttribute("Задание 8", "WinformLab3")]
    public partial class LabTask8 : Form, ITaskLaunchable
    {
        public LabTask8()
        {
            this.InitializeComponent();
            this.exit_button.Click += new EventHandler(ExitButton_Click);
        }

        public string TaskInfo => "Дано целое число N (N > 0), используя один цикл, найти сумму 1! +2! + 3! +...+N!";

        public void TaskLaunch() => this.ShowDialog();

        private void Calculate_Click(object sender, EventArgs e)
        {
            var Task = new Task8Logic();
            result_textbox.Text = (Task.Calculate(Convert.ToInt32(value_numeric.Value))).ToString();
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}
