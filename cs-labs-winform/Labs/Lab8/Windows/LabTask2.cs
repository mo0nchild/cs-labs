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
    [TaskDetectAttribute("Задание 2", "WinformLab8")]
    public partial class LabTask2 : Form, ITaskLaunchable
    {
        private Labs.Lab8.LabLogic lab_logic = new();
        public LabTask2()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };

            this.create_button.Click += new EventHandler(CreateButtonClick);
            this.root_button.Click += new EventHandler(RootButtonClick);
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

        private void CreateButtonClick(object? sender, EventArgs args)
        {
            if (this.rootpath_textbox.Text == String.Empty || this.foldername_textbox.Text == String.Empty) return;

            try { lab_logic.LabTask2(this.rootpath_textbox.Text, this.foldername_textbox.Text); }
            catch(System.Exception error) { MessageBox.Show($"{error.Message}", "Ошибка"); return; }

            MessageBox.Show($"Каталог {this.foldername_textbox.Text} создан", "Готово");
        }

        public string TaskInfo => "Разработать интерфейс приложения и реализовать функции создания папки.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
