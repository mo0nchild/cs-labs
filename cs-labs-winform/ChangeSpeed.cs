using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            this.Moto2 = moto;
            numericUpDown1.Value = (decimal)Moto2.Speed;
        }

        private void XChange_Click(object sender, EventArgs e)
        {


            if (Moto2.Speed + Convert.ToDouble(numericUpDown1.Value) > Moto2.MaxSpeed || Moto2.Speed + Convert.ToDouble(numericUpDown1.Value) < 0)
            {
                MessageBox.Show("Неверное значение");
                UPSpeed = 0;
            }
                
            else
            {
                UPSpeed = Convert.ToDouble(numericUpDown1.Value);
            }
        }

        public MotoBike Moto2 { get; set; }
        public static double UPSpeed;
    }
}
