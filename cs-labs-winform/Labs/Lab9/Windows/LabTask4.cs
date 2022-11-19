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

namespace CSharpLabs.Lab9.Windows
{
    [TaskDetectAttribute("Задание 4", "WinformLab9")]
    public partial class LabTask4 : Form, ITaskLaunchable
    {
        private Labs.Lab9.Lab9Logic LabLogic { get; set; } = new();
        public LabTask4()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };

            this.file_button.Click += new EventHandler(FileButtonClick);
        }

        private void FileButtonClick(object? sender, EventArgs args)
        {
            using (var filedialog = new OpenFileDialog())
            {
                if (filedialog.ShowDialog() != DialogResult.OK) return;

                this.filepath_textbox.Text = filedialog.FileName;
                var result = this.LabLogic.LabTask4(filedialog.FileName);

                this.accesstime_textbox.Text = result.LastAccess;
                this.createtime_textbox.Text = result.CreateTime;
                this.writetime_textbox.Text = result.LastWrite;
            }
        }

        public string TaskInfo => "Разработать функции получения информации о заданном файле.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
