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
    [TaskDetectAttribute("Задание 3", "WinformLab6")]
    public partial class LabTask3 : Form, ITaskLaunchable
    {
        private Queue<Logic.Motobike> motobikes = new Queue<Logic.Motobike>();
        public LabTask3()
        {
            this.InitializeComponent();

            this.add_button.Click += Add_button_Click;
            this.delete_button.Click += Delete_button_Click;
            this.info_button.Click += Info_button_Click;
            this.exit_button.Click += (sender, e) => this.Close();

            this.mototype_combobox.SelectedIndex = 0;
        }

        private void Info_button_Click(object? sender, EventArgs e)
        {
            var current_moto = this.motobikes.Peek();

            this.motoname_textbox.Text = current_moto.Name;
            this.motospeed_numeric.Value = (decimal)current_moto.MaxSpeed;
            this.mototype_combobox.Text = current_moto.Type.ToString();

            this.RefreshListView();
        }

        private void Delete_button_Click(object? sender, EventArgs e)
        {
            var current_moto = this.motobikes.Dequeue();

            this.motoname_textbox.Text = current_moto.Name;
            this.motospeed_numeric.Value = (decimal)current_moto.MaxSpeed;
            this.mototype_combobox.Text = current_moto.Type.ToString();

            this.RefreshListView();
        }

        private void Add_button_Click(object? sender, EventArgs e)
        {
            var moto_name = this.motoname_textbox.Text;
            var moto_speed = (double)this.motospeed_numeric.Value;
            object moto_type  = new();

            try { moto_type = Enum.Parse(typeof(Logic.Motobike.MotoType), this.mototype_combobox.Text); }
            catch { MessageBox.Show("Ошибка преобразования", "Ошибка"); return; }

            this.motobikes.Enqueue(new Logic.Motobike(moto_speed, (Logic.Motobike.MotoType)moto_type) { Name = moto_name });
            this.RefreshListView();
        }

        private void RefreshListView() 
        {
            this.motos_listview.Items.Clear();
            foreach (var item in this.motobikes)
            {
                var row = new ListViewItem(new String[] {
                    item.ServiceNumber.ToString(),
                    item.Name,
                    item.MaxSpeed.ToString(),
                    item.Type.ToString()
                });
                this.motos_listview.Items.Add(row);
            }
        }

        public string TaskInfo => "Создать приложение, демонстрирующее функции ввода-вывода заданой коллекции в соответствии с вариантом.";

        public void TaskLaunch() => this.ShowDialog();
    }
}
