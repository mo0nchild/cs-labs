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
    public partial class ChangeSpeed : Form
    {
        public ChangeSpeed(MotoBike moto)
        {
            InitializeComponent();
            this.moto2 = moto;
        }

        private void XChange_Click(object sender, EventArgs e)
        {


            if (moto2.Speed + Convert.ToDouble(numericUpDown1.Value) > moto2.MaxSpeed || moto2.Speed + Convert.ToDouble(numericUpDown1.Value) < 0) 
                MessageBox.Show("Неверное значение");
            else
            {
                //moto2.Speed = Convert.ToDouble(numericUpDown1.Value);
            }
        }

        public MotoBike moto2 { get; set; }

    }
}
