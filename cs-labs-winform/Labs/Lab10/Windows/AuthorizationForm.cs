using CSharpLabs.Lab10.Logics;
using CSharpLabs.Labs.Lab10.Windows;
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
    [TaskDetectAttribute("Авторизация", "WinformLab10")]
    public partial class AuthorizationForm : Form, ITaskLaunchable
    {
        private IProfileAuthorization<ProfileModel> AuthController { get; set; } = default!;

        public AuthorizationForm()
        {
            this.AuthController = new ProfileAuthorization();
            this.InitializeComponent();

            this.registration_button.Click += Registration_button_Click;
        }

        private void AuthorizateWithLogin_Click(object sender, EventArgs e)
        {
            ProfileAuthorization profileAuthorization = new ProfileAuthorization();
            var resultProfile = profileAuthorization.Authorization(LogintextBox.Text, PasswordTextBox.Text);

            if (resultProfile == Guid.Empty) return;

            var profile_form = new ProfileForm(this.AuthController, resultProfile);
            profile_form.ShowDialog();
        }

        private void AuthorizationWithKey_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            ProfileAuthorization profileAuthorization = new ProfileAuthorization();
            var resultPath = profileAuthorization.Authorization(openFileDialog1.FileName);

            if (resultPath == Guid.Empty) return;

            var profile_form = new ProfileForm(this.AuthController, resultPath);
            profile_form.ShowDialog();
        }

        private void Registration_button_Click(object? sender, EventArgs e)
        {
            new RegistrationForm(this.AuthController).ShowDialog();
        }

        public string TaskInfo => "Создать форму для регистрации пользователя. (должны быть указаны поля авторизации)";

        public void TaskLaunch() => this.ShowDialog();
    }
}
