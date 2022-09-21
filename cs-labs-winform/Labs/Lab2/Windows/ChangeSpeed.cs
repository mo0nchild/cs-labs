using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.Logics;

namespace CSharpLabs.Windows
{
    public partial class ChangeSpeed : Form
    {
        private MotoBike motobike_instance = default;
        public MotoBike NewMotoBike { get => this.motobike_instance; }

        public ChangeSpeed(MotoBike motobike_instance) 
        {
            this.InitializeComponent();
            this.motobike_instance = motobike_instance;
        }

        private void XChange_Click(object sender, EventArgs e)
        {
            try { this.motobike_instance.SpeedUp((double)this.numericUpDown1.Value); }
            catch(Exception error) { MessageBox.Show(error.Message); return; }

            MessageBox.Show($"Текущая скорость: { this.motobike_instance.Speed }");
        }
    }
}
