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
    public partial class Create_Form : Form
    {
        public Create_Form()
        {
            InitializeComponent();
        }
        
        private void Create_Moto_Click(object sender, EventArgs e)
        {
          string temp = ""; 
          
          switch (Model_value.Text)
           {
                case "scooter":    temp =   "1";    break;
                case "classic":    temp =   "2";    break;
                case "sports":     temp =   "3";    break;
                case "adventure":  temp =   "4";    break;
                //default: Console.WriteLine(Model_value.Text); break;
           }

          var mot = (MotoType)Enum.Parse(typeof(MotoType), temp);
          newMotoBike = new MotoBike(Convert.ToDouble(max_speed_value.Value), mot );
          Console.WriteLine(newMotoBike.ToString());
          
        }

        public MotoBike newMotoBike { get; set; }

    }
}
