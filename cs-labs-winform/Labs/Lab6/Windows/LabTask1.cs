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

namespace CSharpLabs.Lab6.Windows
{
    [TaskDetectAttribute("Задание 1", "WinformLab6")]
    public partial class LabTask1 : Form, ITaskLaunchable
    {
        private List<string> values = new();

        public LabTask1()
        {
            this.InitializeComponent();
            this.operations_listbox.SetSelected(0, true);

            this.exit_button.Click += (sender, e) => this.Close();
            this.add_button.Click += Add_button_Click;
        }

        private void Add_button_Click(object? sender, EventArgs e)
        {
            var value = this.value_textbox.Text;
            try 
            {
                switch (this.operations_listbox.SelectedIndex)
                {
                    case 0: this.values.Add(value); break;
                    case 1: this.values.Insert(this.values_listbox.SelectedIndex + 1, value); break;
                    case 2: this.values.RemoveAt(this.values_listbox.SelectedIndex); break;
                    case 3: this.values.Sort(); break;
                    case 4: this.values.Clear(); break;
                    default: MessageBox.Show("Невозможно выбрать операцию", "Ошибка"); break;
                }
            }
            catch { MessageBox.Show("Невозможно выполнить операцию", "Ошибка"); return; }

            this.values_listbox.Items.Clear();
            for (var i = 0; i < this.values.Count; i++) 
                this.values_listbox.Items.Add($"Значение {i + 1}: {values[i]}");
        }

        public string TaskInfo => "Создать однотипную коллекцию объектов List<T> и добавить основные методы работы с ним.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
