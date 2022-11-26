using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabs.Lab11.Windows
{
    internal partial class ProfileDataForm : Form
    {
        internal ProfileDataForm(Logics.User profile)
        {
            this.InitializeComponent();
            this.textBox1.Text = profile.ToString();
        }
    }
}
