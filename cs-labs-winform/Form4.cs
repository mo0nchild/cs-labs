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
    public partial class Condition_Form : Form
    {
        public Condition_Form(MotoBike moto)
        {
            InitializeComponent();
            condition_motobike = moto;
            Condition_View();
        }

        private void Condition_View()
        {
            model_value.Text =  condition_motobike.Type.ToString();
            speed_value.Text =  condition_motobike.Speed.ToString();
            max_speed_value.Text = condition_motobike.MaxSpeed.ToString();
            serial_number_value.Text = condition_motobike.ServiceNumber.ToString();

            MotoType type = condition_motobike.Type;

            switch (type)
            {
                case MotoType.Classic:
                    pictureBox1.Image = Image.FromFile("..//..//..//assets/classic.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Scooter:
                    pictureBox1.Image = Image.FromFile("..//..//..//assets/scooter.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Sports:
                    pictureBox1.Image = Image.FromFile("..//..//..//assets/sports.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Tourer:
                    pictureBox1.Image = Image.FromFile("..//..//..//assets/adventure.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default: 
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private static MotoBike condition_motobike;

    }
}
