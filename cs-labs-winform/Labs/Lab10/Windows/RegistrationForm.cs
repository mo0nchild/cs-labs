using CSharpLabs.Lab10.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLabs.Labs.Lab10.Windows
{
    public partial class RegistrationForm : Form
    {
        private IProfileAuthorization<ProfileModel> AuthController { get; set; } = default!;
        private System.Boolean PasswordChecker { get; set; } = default;

        public RegistrationForm(IProfileAuthorization<ProfileModel> auth_controller)
        {
            this.AuthController = auth_controller;
            this.InitializeComponent();

            this.registration_button.Click += Registration_button_Click;
            this.password_textbox.TextChanged += Password_textbox_TextChanged;
            this.InstallComboboxResourse();
        }

        private void Password_textbox_TextChanged(object? sender, EventArgs args)
        {
            var password = this.password_textbox.Text;
            var regex_expressions = new string[] { @"\w+", @"[@#$!%^&*()_+]" };

            if (password.Length >= 8)
            {
                var checker_error = default(bool);
                foreach (var items in regex_expressions)
                {
                    if(!Regex.IsMatch(password, items)) checker_error = true;
                }
                if(checker_error == default(bool))
                {
                    this.validation_panel.BackColor = Color.GreenYellow;
                    this.PasswordChecker = true; return;
                }
            }
            this.validation_panel.BackColor = Color.Salmon;
            this.PasswordChecker = false;
        }

        private void InstallComboboxResourse()
        {
            this.gender_combobox.SelectedIndex = 0;
            using (var filereader = new StreamReader(File.OpenRead("ResourseFacoulty.txt")))
            {
                while(filereader.Peek() != -1) this.faculty_combobox.Items.Add(filereader.ReadLine());
            }
            using (var filereader = new StreamReader(File.OpenRead("ResoursePost.txt")))
            {
                while (filereader.Peek() != -1) this.post_combobox.Items.Add(filereader.ReadLine());
            }
            if (this.faculty_combobox.Items.Count > 0) this.faculty_combobox.SelectedIndex = 0;
            if (this.post_combobox.Items.Count > 0) this.post_combobox.SelectedIndex = 0;
        }

        private void Registration_button_Click(object? sender, EventArgs args)
        {
            if (this.PasswordChecker == false) return;

            var profile_data = new ProfileModel()
            {
                Birthday = this.birthday_datetime.Value,
                FIO = this.FIO_textbox.Text,
                Login = this.login_textbox.Text,
                Password = this.password_textbox.Text,
                Faculty = this.faculty_combobox.Text,
                Post = this.post_combobox.Text,
                Gender = Enum.Parse<ProfileModel.GenderType>(this.gender_combobox.Text)
            };
            try { this.AuthController.Registration(profile_data); }
            catch (Exception error) { MessageBox.Show(error.Message, "Ошибка"); return; }

            MessageBox.Show("Профиль зарегистрирован", "Готово");
            this.DialogResult = DialogResult.OK;
        }
    }
}
