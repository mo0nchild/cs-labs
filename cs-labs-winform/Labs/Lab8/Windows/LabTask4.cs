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
    [TaskDetectAttribute("Задание 4", "WinformLab8")]
    public partial class LabTask4 : Form, ITaskLaunchable
    {
        private Labs.Lab8.LabLogic lab_logic = new();
        public LabTask4()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };
            this.root_button.Click += new EventHandler(RootButtonClick);
        }

        private void RootButtonClick(object? sender, EventArgs args)
        {
            using (var filepath = new OpenFileDialog() { Filter = "Текстовый файл (*.TXT)|*.txt" })
            {
                var result = filepath.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(filepath.FileName))
                {
                    this.rootpath_textbox.Text = filepath.FileName;
                }
            }
            try { this.message_textbox.Text = this.lab_logic.LabTask4(this.rootpath_textbox.Text); }
            catch { MessageBox.Show("Невозможно прочитать файл", "Ошибка"); }
        }

        public string TaskInfo => "Разработать интерфейс приложения и реализовать функции чтения из файла.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
