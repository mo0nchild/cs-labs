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

using CSharpLabs.Lab11.Logics;

namespace CSharpLabs.Lab11.Windows
{
    [type: TaskDetectAttribute("Авторизация", "WinformLab11")]
    public partial class AuthorizationForm : Form, ITaskLaunchable
    {
        private List<User> UsersProfile { get; set; } = new();

        public AuthorizationForm() 
        {
            this.InitializeComponent();

            this.reg_button.Click += Reg_button_Click;
            this.auth_button.Click += Auth_button_Click;

            this.gender_combobox.SelectedIndex = 0;
            this.back_button.Click += delegate { this.Close(); };
        }

        private void Auth_button_Click(object? sender, EventArgs args)
        {
            foreach (var user in this.UsersProfile)
            {
                var profile = user.Authorization(this.login_textbox.Text, this.password_textbox.Text);
                if (profile != null) 
                {
                    var profile_form = new ProfileDataForm(user);
                    profile_form.ShowDialog(); break;
                }
            }
        }

        private void Reg_button_Click(object? sender, EventArgs args)
        {
            foreach (var profile in this.UsersProfile)
            {
                if (profile.Login == this.reg_login_textbox.Text 
                    && profile.Password == this.reg_password_textbox.Text)
                {
                    MessageBox.Show("Учетная запись уже существует", "Ошибка");
                    return;
                }
            }

            switch (this.tabControl2.SelectedIndex)
            {
                case 0:
                    this.UsersProfile.Add(new Person(this.reg_login_textbox.Text, this.reg_password_textbox.Text)
                    {
                        Birthday = this.birthday_datetime.Value,
                        FIO = this.fio_textbox.Text,
                        Gender = Enum.Parse<Person.GenderType>(this.gender_combobox.Text)
                    });
                    break;
                case 1:
                    this.UsersProfile.Add(new Employee(this.reg_login_textbox.Text, this.reg_password_textbox.Text)
                    {
                        Birthday = this.birthday_datetime.Value,
                        FIO = this.fio_textbox.Text,
                        Gender = Enum.Parse<Person.GenderType>(this.gender_combobox.Text),
                        Faculty = this.faculty_textbox.Text,
                        Post = this.post_textbox.Text
                    });
                    break;
                case 2:
                    this.UsersProfile.Add(new Abiturient(this.reg_login_textbox.Text, this.reg_password_textbox.Text)
                    {
                        Birthday = this.birthday_datetime.Value,
                        FIO = this.fio_textbox.Text,
                        Gender = Enum.Parse<Person.GenderType>(this.gender_combobox.Text),
                        Certificate = this.certificate_textbox.Text,
                        ScoreCount = (int)this.score_numeric.Value
                    });
                    break;
                default: break;
            }
            MessageBox.Show("Профиль зарегистрирован", "Готово");
        }

        public string TaskInfo => "Разработать интерфейс для авторизации сотрудника, абитуриента и гостя.";
        public void TaskLaunch() => this.ShowDialog();
    }
}
