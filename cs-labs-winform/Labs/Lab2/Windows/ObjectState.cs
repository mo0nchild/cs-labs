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

namespace CSharpLabs.Lab2.Windows
{
    public partial class Condition_Form : Form
    {
        private MotoBike condition_motobike = default;

        public Condition_Form(MotoBike moto)
        {
            this.InitializeComponent();
            this.condition_motobike = moto;
            this.Condition_View();
        }

        private void Condition_View()
        {
            this.serial_number_value.Text = condition_motobike.ServiceNumber.ToString();
            this.model_value.Text =  condition_motobike.Type.ToString();

            this.max_speed_value.Text = condition_motobike.MaxSpeed.ToString();
            this.speed_value.Text =  condition_motobike.Speed.ToString();

            string assetsfolder_path = @".\..\..\..\Labs\Lab2\Assets";
            switch (this.condition_motobike.Type)
            {
                case MotoType.Classic:
                    this.pictureBox1.Image = Image.FromFile(assetsfolder_path + "\\classic.jpg");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Scooter:
                    this.pictureBox1.Image = Image.FromFile(assetsfolder_path + "\\scooter.jpg");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Sports:
                    this.pictureBox1.Image = Image.FromFile(assetsfolder_path + "\\sports.jpg");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case MotoType.Tourer:
                    this.pictureBox1.Image = Image.FromFile(assetsfolder_path + "\\adventure.jpg");
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default: 
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }
    }
}
