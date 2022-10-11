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
    [TaskDetectAttribute("Задание 3", "WinformLab5")]
    public partial class LabTask3 : Form, ITaskLaunchable
    {
        private Labs.Lab5.LabLogic lab_logic = new();
        public LabTask3()
        {
            this.InitializeComponent();
            this.lab_logic.RegisterDeligate((string msg) => MessageBox.Show(msg, "Ошибка"));
            this.lang_combobox.SelectedIndex = 0;

            this.calc_button.Click += Calc_button_Click;
            this.exit_button.Click += Exit_button_Click;
        }

        private void Exit_button_Click(object? sender, EventArgs e) => this.Close();

        private void Calc_button_Click(object? sender, EventArgs e)
        {
            var result = this.lab_logic.Task3(this.input_textbox.Text, this.lang_combobox.Text);
            if (result is null) return;

            this.result_textbox.Text = result;
        }

        public string TaskInfo => "Удалить из данного слова все гласные буквы";

        public void TaskLaunch() => this.ShowDialog();
    }
}
