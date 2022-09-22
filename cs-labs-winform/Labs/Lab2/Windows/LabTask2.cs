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
    public partial class LabTask2 : Form
    {
        private MotoBike moto_bike = default;

        public LabTask2()
        {
            this.InitializeComponent();
            this.Create_MotoBike_Standart();

            this.condition.Click += new System.EventHandler(this.ConditionButtonClick);
            this.speed.Click += new System.EventHandler(this.SpeedUpButtonClick);

            this.create_motobike.Click += new System.EventHandler(this.CreateMotoBikeButtonClick);
            this.back_to_titile.Click += new System.EventHandler(this.BackButtonClick);
        }

        private void ConditionButtonClick(object? sender, EventArgs e)
        {
            var condition_form = new Condition_Form(moto_bike);
            condition_form.ShowDialog();
        }

        private void CreateMotoBikeButtonClick(object? sender, EventArgs e)
        {
            var create_form = new Create_Form();
            if(create_form.ShowDialog() != DialogResult.Cancel) this.moto_bike = create_form.NewMotoBike;
        }

        private void SpeedUpButtonClick(object? sender, EventArgs e)
        {
            var change_speed = new ChangeSpeed(moto_bike);
            change_speed.ShowDialog();

            this.moto_bike = change_speed.NewMotoBike;
        }

        private void BackButtonClick(object? sender, EventArgs e) => this.Close();
        
        private void Create_MotoBike_Standart() => this.moto_bike = new MotoBike();
    }
}
