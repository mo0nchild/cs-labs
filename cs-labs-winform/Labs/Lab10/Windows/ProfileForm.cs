using CSharpLabs.Lab10.Logics;
using CSharpLabs.LabsLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabs.Lab10.Windows
{
    public partial class ProfileForm : Form
    {
        private ProfileModel ProfileData { get; set; } = default!;

        public ProfileForm(IProfileAuthorization<ProfileModel> controller, System.Guid profile_id)
        {
            try { this.ProfileData = controller.GetProfileRecord(profile_id); }
            catch (System.Exception error) { MessageBox.Show(error.Message, "Ошибка"); return; }

            this.InitializeComponent();
            this.Load += new EventHandler(ProfileForm_Load);
        }

        private void ProfileForm_Load(object? sender, EventArgs args)
        {
            this.Faculty_textBox.Text = this.ProfileData.Faculty;
            this.Birthday_Peeker.Value = this.ProfileData.Birthday;

            this.Gender_textBox.Text = this.ProfileData.Gender.ToString();
            this.Login_textBox.Text = this.ProfileData.Login;

            this.Password_textBox.Text = this.ProfileData.Password;
            this.Post_textBox.Text = this.ProfileData.Post;

            this.textBox2.Text = this.ProfileData.Key.ToString();
            this.FIO_textBox.Text = this.ProfileData.FIO;
        }
    }
}
