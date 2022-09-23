using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpLabs.Lab2.Logics;
using CSharpLabs.Labs.Lab2.Logics;

namespace CSharpLabs.Lab3.Windows
{
    public partial class LabTask8 : Form
    {
        public LabTask8()
        {
            this.InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            var Task = new Calculate_Task8();

            Result_v.Text = (Task.Calculate_with_Fact(Convert.ToInt32(numericUpDown1.Value))).ToString();
        }
    }
}
