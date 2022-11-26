namespace CSharpLabs.Lab11.Windows
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.auth_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_login_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_password_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fio_textbox = new System.Windows.Forms.TextBox();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.birthday_datetime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.post_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.faculty_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.certificate_textbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.score_numeric = new System.Windows.Forms.NumericUpDown();
            this.reg_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.score_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.Location = new System.Drawing.Point(6, 297);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(408, 31);
            this.back_button.TabIndex = 0;
            this.back_button.Text = "Выйти в главное меню";
            this.back_button.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(408, 279);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reg_button);
            this.tabPage2.Controls.Add(this.birthday_datetime);
            this.tabPage2.Controls.Add(this.gender_combobox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.fio_textbox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.reg_password_textbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.reg_login_textbox);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(400, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 156);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(388, 89);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(380, 61);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Гость";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.faculty_textbox);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.post_textbox);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(380, 61);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Работник";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.score_numeric);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.certificate_textbox);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(380, 61);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Абитуриент";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.auth_button);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.password_textbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.login_textbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(400, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // login_textbox
            // 
            this.login_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_textbox.Location = new System.Drawing.Point(64, 63);
            this.login_textbox.MaxLength = 100;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(275, 29);
            this.login_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            // 
            // password_textbox
            // 
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textbox.Location = new System.Drawing.Point(64, 113);
            this.password_textbox.MaxLength = 100;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '$';
            this.password_textbox.Size = new System.Drawing.Size(275, 29);
            this.password_textbox.TabIndex = 2;
            // 
            // auth_button
            // 
            this.auth_button.BackColor = System.Drawing.Color.White;
            this.auth_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auth_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.auth_button.Location = new System.Drawing.Point(64, 186);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(275, 31);
            this.auth_button.TabIndex = 2;
            this.auth_button.Text = "Войти в профиль";
            this.auth_button.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Логин:";
            // 
            // reg_login_textbox
            // 
            this.reg_login_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_login_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg_login_textbox.Location = new System.Drawing.Point(6, 21);
            this.reg_login_textbox.MaxLength = 100;
            this.reg_login_textbox.Name = "reg_login_textbox";
            this.reg_login_textbox.Size = new System.Drawing.Size(179, 29);
            this.reg_login_textbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль:";
            // 
            // reg_password_textbox
            // 
            this.reg_password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reg_password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg_password_textbox.Location = new System.Drawing.Point(211, 21);
            this.reg_password_textbox.MaxLength = 100;
            this.reg_password_textbox.Name = "reg_password_textbox";
            this.reg_password_textbox.Size = new System.Drawing.Size(179, 29);
            this.reg_password_textbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пол:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "ФИО:";
            // 
            // fio_textbox
            // 
            this.fio_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fio_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fio_textbox.Location = new System.Drawing.Point(6, 121);
            this.fio_textbox.MaxLength = 100;
            this.fio_textbox.Name = "fio_textbox";
            this.fio_textbox.Size = new System.Drawing.Size(179, 29);
            this.fio_textbox.TabIndex = 10;
            // 
            // gender_combobox
            // 
            this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Items.AddRange(new object[] {
            "Man",
            "Woman"});
            this.gender_combobox.Location = new System.Drawing.Point(211, 71);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(179, 29);
            this.gender_combobox.TabIndex = 12;
            // 
            // birthday_datetime
            // 
            this.birthday_datetime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday_datetime.Location = new System.Drawing.Point(6, 71);
            this.birthday_datetime.Name = "birthday_datetime";
            this.birthday_datetime.Size = new System.Drawing.Size(179, 29);
            this.birthday_datetime.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Должность:";
            // 
            // post_textbox
            // 
            this.post_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.post_textbox.Location = new System.Drawing.Point(6, 21);
            this.post_textbox.MaxLength = 100;
            this.post_textbox.Name = "post_textbox";
            this.post_textbox.Size = new System.Drawing.Size(169, 29);
            this.post_textbox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Факультет:";
            // 
            // faculty_textbox
            // 
            this.faculty_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.faculty_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faculty_textbox.Location = new System.Drawing.Point(201, 21);
            this.faculty_textbox.MaxLength = 100;
            this.faculty_textbox.Name = "faculty_textbox";
            this.faculty_textbox.Size = new System.Drawing.Size(173, 29);
            this.faculty_textbox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Аттестат:";
            // 
            // certificate_textbox
            // 
            this.certificate_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.certificate_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.certificate_textbox.Location = new System.Drawing.Point(6, 21);
            this.certificate_textbox.MaxLength = 100;
            this.certificate_textbox.Name = "certificate_textbox";
            this.certificate_textbox.Size = new System.Drawing.Size(169, 29);
            this.certificate_textbox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Рейтинг:";
            // 
            // score_numeric
            // 
            this.score_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score_numeric.Location = new System.Drawing.Point(201, 21);
            this.score_numeric.Name = "score_numeric";
            this.score_numeric.Size = new System.Drawing.Size(163, 29);
            this.score_numeric.TabIndex = 20;
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.White;
            this.reg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reg_button.Location = new System.Drawing.Point(211, 121);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(179, 31);
            this.reg_button.TabIndex = 14;
            this.reg_button.Text = "Зарегистрироваться";
            this.reg_button.UseVisualStyleBackColor = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Авторизация";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.score_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button back_button;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage1;
        private Button auth_button;
        private Label label2;
        private TextBox password_textbox;
        private Label label1;
        private TextBox login_textbox;
        private TextBox reg_password_textbox;
        private Label label4;
        private Label label3;
        private TextBox reg_login_textbox;
        private Label label6;
        private Label label5;
        private ComboBox gender_combobox;
        private Label label7;
        private TextBox fio_textbox;
        private DateTimePicker birthday_datetime;
        private Label label9;
        private TextBox faculty_textbox;
        private Label label8;
        private TextBox post_textbox;
        private NumericUpDown score_numeric;
        private Label label11;
        private Label label10;
        private TextBox certificate_textbox;
        private Button reg_button;
    }
}