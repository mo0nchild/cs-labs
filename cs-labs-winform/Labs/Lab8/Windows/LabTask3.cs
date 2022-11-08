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
    [TaskDetectAttribute("Задание 3", "WinformLab8")]
    public partial class LabTask3 : Form, ITaskLaunchable
    {
        private Labs.Lab8.LabLogic lab_logic = new();
        public LabTask3()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };
            this.method_combobox.SelectedIndex = default(int);

            this.root_button.Click += new EventHandler(RootButtonClick);
            this.write_button.Click += new EventHandler(WriteButtonClick);
        }

        private void WriteButtonClick(object? sender, EventArgs args)
        {
            var message_list = this.message_textbox.Lines;
            var method_type = Enum.Parse<Labs.Lab8.LabLogic.FileCreateMethod>(this.method_combobox.Text);
            var filepath = $"{this.rootpath_textbox.Text}\\{this.filename_textbox.Text}";

            try { this.lab_logic.LabTask3(filepath, method_type, message_list); }
            catch { MessageBox.Show("Невозможно создать файл", "Ошибка"); return; }

            MessageBox.Show($"Файл {this.filename_textbox.Text} успешно создан", "Готово");
        }

        private void RootButtonClick(object? sender, EventArgs args)
        {
            using (var filepath = new FolderBrowserDialog())
            {
                var result = filepath.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(filepath.SelectedPath))
                {
                    this.rootpath_textbox.Text = filepath.SelectedPath;
                }
            }
        }

        public string TaskInfo => "Разработать интерфейс приложения и реализовать функции создания текстового файла различными методами.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
