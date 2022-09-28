using CSharpLabs.Lab3.Logics;
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

namespace CSharpLabs.Lab3.Windows
{
    [type: TaskDetectAttribute("Задание 6", "WinformLab3")]
    public partial class LabTask6 : Form, ITaskLaunchable
    {
        private Task6Logic task_logic = new();

        public LabTask6()
        {
            this.InitializeComponent();

            this.exit_button.Click += new EventHandler(ExitButton_Click);
            this.calc_button.Click += new EventHandler(CalculateButton_Click);
        }

        public string TaskInfo => "Вычисление значений заданной функции в каждой точке отрезка и найти сумму полученных значений.";
        public void TaskLaunch() => this.ShowDialog();

        private void CalculateButton_Click(object? sender, EventArgs e) 
        {
            this.task_logic = new((int)this.leftside_numeric.Value, (int)this.rightside_numeric.Value, 
                (double)this.step_numeric.Value);
            this.result_textbox.Text = this.task_logic.GetSummary().ToString();

            this.result_listview.Items.Clear();
            foreach (var item in this.task_logic) 
            {
                var row_strings = new string[] { (Math.Round(item.Key,2)).ToString(), item.Value.ToString() };
                this.result_listview.Items.Add(new ListViewItem(row_strings));
            }
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}
