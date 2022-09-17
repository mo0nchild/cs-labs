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
    public partial class LabTask1 : Form
    {
        public LabTask1()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e) => this.Close();

        private void task1_calc_button_Click(object sender, EventArgs e)
        {
            double x = (double)this.task1_x_numeric.Value, y = (double)this.task1_y_numeric.Value, z = (double)this.task1_z_numeric.Value;

            double a = y + (x / (Math.Pow(y, 2) + Math.Abs(Math.Pow(x, 2) / (y + Math.Pow(x, 2))))),
                b = Math.Pow(1 + Math.Pow(Math.Tan(z / 2), 2), 2);

            this.task1_resulta_textbox.Text = a.ToString();
            this.task1_resultb_textbox.Text = b.ToString();
        }

        private void task2_calc_button_Click(object sender, EventArgs e)
        {
            double height = (double)this.task2_height_numeric.Value, speed = (double)this.task2_speed_numeric.Value;
            this.task2_falltime_textbox.Text = CalculateTime(height, speed).ToString();

            double CalculateTime(double h, double _v) => (Math.Sqrt(2 * 10.0 * h + Math.Pow(_v, 2)) - _v) / 10.0;
        }

        private void task3_calc_button_Click(object sender, EventArgs e)
        {
            double a = (double)this.task3_a_numeric.Value, b = (double)this.task3_b_numeric.Value, c = (double)this.task3_c_numeric.Value;
            this.task3_result_textbox.Text = "Решение уравнения " + (CalculateTruth(a, b, c) ? "возможно" : "невозможно");

            bool CalculateTruth(double a, double b, double c) => (Math.Pow(b, 2) - (4.0 * a * c) >= 0);
        }
    }
}
