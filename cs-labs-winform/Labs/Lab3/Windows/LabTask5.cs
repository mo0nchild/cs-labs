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
    [type: TaskDetectAttribute("Задание 5", "WinformLab3")]
    public partial class LabTask5 : Form, ITaskLaunchable
    {
        public string TaskInfo => "Найти сумму бесконечного ряда. Суммировать пока члены ряда не станут меньше заданного eps > 0.";

        public LabTask5()
        {
            this.InitializeComponent();

            this.exit_button.Click += new EventHandler(ExitButton_Click);
            this.calc_button.Click += new EventHandler(calc_button_Click);
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
        private void calc_button_Click(object? sender, EventArgs e)
        {
            var Task = new Task5Logic();
            result_textbox.Text = (Task.calculate_row((float)value_e_numeric.Value)).ToString();
        }

        public void TaskLaunch() => this.ShowDialog();

    }
}
