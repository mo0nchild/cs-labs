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
    public partial class Create_Form : Form
    {
        public MotoBike NewMotoBike { get; set; }

        public Create_Form()
        {
            this.InitializeComponent();
            this.Model_value.SelectedIndex = default(int);
        }

        private void Create_Moto_Click(object sender, EventArgs e)
        {
            string temp = ""; 
          
            switch (this.Model_value.Text)
            {
                case "scooter":    temp =   "1";    break;
                case "classic":    temp =   "2";    break;
                case "sports":     temp =   "3";    break;
                case "adventure":  temp =   "4";    break;
            }

            var moto_type = (MotoType)Enum.Parse(typeof(MotoType), temp);
            this.NewMotoBike = new MotoBike((double)max_speed_value.Value, moto_type);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
