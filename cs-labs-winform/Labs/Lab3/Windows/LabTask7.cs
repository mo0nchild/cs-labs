using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.Lab3.Logics;

namespace CSharpLabs.Lab3.Windows
{
    public partial class LabTask7 : Form
    {
        public LabTask7()
        {
            this.InitializeComponent();

            this.value_textbox.TextChanged += new EventHandler(ValueTextBox_Changed);
            this.exit_button.Click += new EventHandler(ExitButton_Click);
        }

        private void ValueTextBox_Changed(object? sender, EventArgs e) 
        {
            try
            {
                if (int.TryParse(this.value_textbox.Text, out var value))
                {
                    var task_logic = new Task7Logic(value);

                    this.result_textbox.Text = (oprimazed_checkbox.Checked ? task_logic.FixErrorOptimazed()
                        : task_logic.FixError()).ToString();
                }
                else throw new Exception("Неверное значение");
            }
            catch (Exception error) { this.result_textbox.Text = error.Message; }
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}
