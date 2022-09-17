using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_labs_winform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Create_MotoBike_Standart();
        }

        private void condition_Click(object sender, EventArgs e)
        {
            var ConditionForm = new Condition_Form(moto_bike);
            ConditionForm.ShowDialog();
        }

        private void create_motobike_Click(object sender, EventArgs e)
        {
            var CreateForm = new Create_Form();
            CreateForm.ShowDialog();
            moto_bike = CreateForm.newMotoBike;
        }

        private void speed_Click(object sender, EventArgs e)
        {
            var Changespeed = new ChangeSpeed(moto_bike);
            Changespeed.ShowDialog();



            
        }

        private void back_to_titile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Create_MotoBike_Standart()
        {
            moto_bike = new MotoBike();
        }

        private MotoBike moto_bike;
    }
}
