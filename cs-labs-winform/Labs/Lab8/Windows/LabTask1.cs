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

namespace CSharpLabs.Lab8.Windows
{
    [TaskDetectAttribute("Задание 1", "WinformLab8")]
    public partial class LabTask1 : Form, ITaskLaunchable
    {
        private List<double> values_list = new();
        private Labs.Lab8.LabLogic lab_logic = new();
        public LabTask1()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };

            this.calc_button.Click += new EventHandler(CalcButtonClick);
            this.add_button.Click += new EventHandler(AddButtonClick);
            this.remove_button.Click += new EventHandler(RemoveButtonClick);
            this.file_button.Click += new EventHandler(FileButtonClick);
        }

        private void FileButtonClick(object? sender, EventArgs args)
        {
            using (var filepath = new FolderBrowserDialog())
            {
                var result = filepath.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(filepath.SelectedPath))
                {
                    this.filename_textbox.Text = $"{filepath.SelectedPath}\\{this.filename_textbox.Text}";
                }
            }
        }

        private void RemoveButtonClick(object? sender, EventArgs args)
        {
            this.values_list.RemoveAt(this.values_listbox.SelectedIndex);
            this.ReDrawListbox();
        }

        private void AddButtonClick(object? sender, EventArgs args)
        {
            this.values_list.Add((double)this.double_numeric.Value);
            this.ReDrawListbox();
        }

        private void ReDrawListbox()
        {
            this.values_listbox.Items.Clear();
            foreach (var item in this.values_list) this.values_listbox.Items.Add(item);
        }

        private void CalcButtonClick(object? sender, EventArgs args)
        {
            var filename = this.filename_textbox.Text;
            if (filename == String.Empty) return;

            var number_str = default(string)!;
            foreach (var item in this.values_list) number_str += $"{item} ";

            var result = this.lab_logic.LabTask1(this.filename_textbox.Text, number_str);
            this.result_textbox.Text = $"Модуль суммы: {result.SumModulus}; " +
                $"Квадрат произведение: {result.ProductSquare}"; 
        }

        public string TaskInfo => "Cоздает файл, содержащий целые числа; находит модуль суммы и квадрат произведения чисел, содержащихся в файле.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
