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

using CSharpLabs.Labs;

namespace CSharpLabs.Lab5.Windows
{
    [TaskDetectAttribute("Задание 1", "WinformLab5")]
    public partial class LabTask1 : Form, ITaskLaunchable
    {
        private Labs.Lab5.LabLogic lab_logic = new();
        public LabTask1()
        {
            this.InitializeComponent();
            this.lab_logic.RegisterDeligate((string msg) => MessageBox.Show(msg, "Ошибка"));

            this.calc_button.Click += Calc_button_Click;
            this.exit_button.Click += Exit_button_Click;
        }

        private void Exit_button_Click(object? sender, EventArgs e) => this.Close();

        private void Calc_button_Click(object? sender, EventArgs e)
        {
            this.result_textbox.Text = this.lab_logic.Task1(this.input_textbox.Text);
        }

        public string TaskInfo => "Поменять в слове первую и последнюю буквы";

        public void TaskLaunch() => this.ShowDialog();
    }
}
