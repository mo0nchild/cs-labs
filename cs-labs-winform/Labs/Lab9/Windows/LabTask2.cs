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
    [TaskDetectAttribute("Задание 2", "WinformLab9")]
    public partial class LabTask2 : Form, ITaskLaunchable
    {
        private Labs.Lab9.Lab9Logic LabLogic { get; set; } = new();
        private List<int> BufferList { get; set; } = new();

        public LabTask2()
        {
            this.InitializeComponent();
            this.exit_button.Click += delegate { this.Close(); };

            this.add_button.Click += new EventHandler(AddButtonClick);
            this.remove_button.Click += new EventHandler(RemoveButtonClick);
            this.save_button.Click += new EventHandler(SaveButtonClick);
        }

        private void SaveButtonClick(object? sender, EventArgs args)
        {
            var offset = (int)this.offset_numeric.Value;
            var new_value = (int)this.insert_numeric.Value;

            var result = this.LabLogic.LabTask2(this.BufferList.ToArray(), offset, new_value);
            this.product_textbox.Text = result.ProductSquare.ToString();
            this.summary_textbox.Text = result.SumModulus.ToString();

            this.filedata_textbox.Text = "";
            foreach(var filevalue in this.LabLogic.ReadValues())
            {
                this.filedata_textbox.Text += $"{filevalue}, ";
            }
        }

        private void RemoveButtonClick(object? sender, EventArgs args)
        {
            this.BufferList.Clear();
            this.UpdateValuesList();
        }

        private void AddButtonClick(object? sender, EventArgs args)
        {
            this.BufferList.Add((int)this.add_numeric.Value);
            this.UpdateValuesList();
        }

        private void UpdateValuesList()
        {
            this.values_listbox.Items.Clear();
            foreach (var item in this.BufferList) this.values_listbox.Items.Add(item);
        }

        public string TaskInfo => "В случайно заданную позицию файла, вставляет заданное пользователем число.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
