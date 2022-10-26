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
    [TaskDetectAttribute("Задание 2", "WinformLab6")]
    public partial class LabTask2 : Form, ITaskLaunchable
    {
        List<Lab6.Logic.Motobike> motoBikes = new List<Lab6.Logic.Motobike>();
        public LabTask2()
        {
            InitializeComponent();

            this.L2_exit_button.Click += (sender, e) => this.Close();

            this.L2_mototype_combobox.SelectedIndex = 0;

        }

        public string TaskInfo => "Создать разнородную (элементом является объект заданного класса) коллекцию объектов List<T>.";

        public void TaskLaunch() => this.ShowDialog();

        private void L2_info_button_Click(object sender, EventArgs e)
        {
            int selected_item = L2_motos_listview.SelectedIndices[0];



            this.RefreshListView();
        }

        private void L2_exit_button_Click(object sender, EventArgs e) => this.Close();

        private void RefreshListView()
        {
            this.L2_motos_listview.Items.Clear();
            foreach (var item in this.motoBikes)
            {
                var row = new ListViewItem(new String[] {
                    item.ServiceNumber.ToString(),
                    item.Name.ToString(),
                    item.MaxSpeed.ToString(),
                    item.Type.ToString(),
                    item.Speed.ToString()
                }); ;
                this.L2_motos_listview.Items.Add(row);
            }
        }

        private void L2_SORT_Click(object sender, EventArgs e)
        {
            motoBikes.Sort();
            this.RefreshListView();
        }

        private void L2_add_button_Click_1(object sender, EventArgs e)
        {
            var moto_name = this.L2_motoname_textbox.Text;
            var moto_speed = (double)this.motospeed_numeric.Value;
            object moto_type = new();

            try { moto_type = Enum.Parse(typeof(Logic.Motobike.MotoType), this.L2_mototype_combobox.Text); }
            catch { MessageBox.Show("Ошибка преобразования", "Ошибка"); return; }
            this.motoBikes.Add(new Logic.Motobike(moto_speed, (Logic.Motobike.MotoType)moto_type) { Name = moto_name });

            this.RefreshListView();
        }

        private void L2_Change_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selected_item = L2_motos_listview.SelectedIndices[0];

                motoBikes[selected_item].SpeedUp(Convert.ToInt32(numericUpDown2.Value));

                this.RefreshListView();
            }
            catch (Exception) { MessageBox.Show("Элемент не выбран", "Ошибка"); }
        }

        private void L2_moto_delete_Click_1(object sender, EventArgs e)
        {
            motoBikes.RemoveAt(L2_motos_listview.SelectedIndices[0]);
            this.RefreshListView();
        }

        private void L2_motos_listview_Click(object sender, EventArgs e)
        {
            int selected_item = L2_motos_listview.SelectedIndices[0];


            propertyGrid1.SelectedObject = motoBikes[selected_item];
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            this.RefreshListView();
        }
    }
}
