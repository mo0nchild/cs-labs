namespace CSharpLabs.Labs.Lab10.Windows
{
    partial class RegistrationForm
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
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.birthday_datetime = new System.Windows.Forms.DateTimePicker();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.FIO_label = new System.Windows.Forms.Label();
            this.FIO_textbox = new System.Windows.Forms.TextBox();
            this.faculty_label = new System.Windows.Forms.Label();
            this.faculty_combobox = new System.Windows.Forms.ComboBox();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.validation_panel = new System.Windows.Forms.Panel();
            this.post_combobox = new System.Windows.Forms.ComboBox();
            this.post_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.registration_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_textbox
            // 
            this.login_textbox.BackColor = System.Drawing.Color.White;
            this.login_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_textbox.Location = new System.Drawing.Point(12, 30);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.Size = new System.Drawing.Size(201, 29);
            this.login_textbox.TabIndex = 0;
            // 
            // birthday_datetime
            // 
            this.birthday_datetime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday_datetime.Location = new System.Drawing.Point(239, 192);
            this.birthday_datetime.Name = "birthday_datetime";
            this.birthday_datetime.Size = new System.Drawing.Size(202, 29);
            this.birthday_datetime.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.Location = new System.Drawing.Point(12, 8);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(50, 19);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Логин:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_label.Location = new System.Drawing.Point(240, 8);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(59, 19);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Пароль:";
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.White;
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textbox.Location = new System.Drawing.Point(240, 30);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(201, 29);
            this.password_textbox.TabIndex = 3;
            // 
            // FIO_label
            // 
            this.FIO_label.AutoSize = true;
            this.FIO_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIO_label.Location = new System.Drawing.Point(12, 62);
            this.FIO_label.Name = "FIO_label";
            this.FIO_label.Size = new System.Drawing.Size(136, 19);
            this.FIO_label.TabIndex = 6;
            this.FIO_label.Text = "ФИО пользователя: ";
            // 
            // FIO_textbox
            // 
            this.FIO_textbox.BackColor = System.Drawing.Color.White;
            this.FIO_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FIO_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FIO_textbox.Location = new System.Drawing.Point(12, 84);
            this.FIO_textbox.Name = "FIO_textbox";
            this.FIO_textbox.Size = new System.Drawing.Size(429, 29);
            this.FIO_textbox.TabIndex = 5;
            // 
            // faculty_label
            // 
            this.faculty_label.AutoSize = true;
            this.faculty_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faculty_label.Location = new System.Drawing.Point(12, 116);
            this.faculty_label.Name = "faculty_label";
            this.faculty_label.Size = new System.Drawing.Size(76, 19);
            this.faculty_label.TabIndex = 8;
            this.faculty_label.Text = "Факультет:";
            // 
            // faculty_combobox
            // 
            this.faculty_combobox.BackColor = System.Drawing.Color.White;
            this.faculty_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.faculty_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faculty_combobox.FormattingEnabled = true;
            this.faculty_combobox.Location = new System.Drawing.Point(11, 138);
            this.faculty_combobox.Name = "faculty_combobox";
            this.faculty_combobox.Size = new System.Drawing.Size(201, 29);
            this.faculty_combobox.TabIndex = 9;
            // 
            // gender_combobox
            // 
            this.gender_combobox.BackColor = System.Drawing.Color.White;
            this.gender_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Items.AddRange(new object[] {
            "Men",
            "Woman"});
            this.gender_combobox.Location = new System.Drawing.Point(239, 138);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(201, 29);
            this.gender_combobox.TabIndex = 11;
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender_label.Location = new System.Drawing.Point(240, 116);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(41, 19);
            this.gender_label.TabIndex = 10;
            this.gender_label.Text = "Пол: ";
            // 
            // validation_panel
            // 
            this.validation_panel.BackColor = System.Drawing.Color.Salmon;
            this.validation_panel.Location = new System.Drawing.Point(240, 62);
            this.validation_panel.Name = "validation_panel";
            this.validation_panel.Size = new System.Drawing.Size(201, 4);
            this.validation_panel.TabIndex = 12;
            // 
            // post_combobox
            // 
            this.post_combobox.BackColor = System.Drawing.Color.White;
            this.post_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.post_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.post_combobox.FormattingEnabled = true;
            this.post_combobox.Location = new System.Drawing.Point(10, 192);
            this.post_combobox.Name = "post_combobox";
            this.post_combobox.Size = new System.Drawing.Size(201, 29);
            this.post_combobox.TabIndex = 14;
            // 
            // post_label
            // 
            this.post_label.AutoSize = true;
            this.post_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.post_label.Location = new System.Drawing.Point(11, 170);
            this.post_label.Name = "post_label";
            this.post_label.Size = new System.Drawing.Size(82, 19);
            this.post_label.TabIndex = 13;
            this.post_label.Text = "Должность:";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday_label.Location = new System.Drawing.Point(240, 170);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(45, 19);
            this.birthday_label.TabIndex = 15;
            this.birthday_label.Text = "label7";
            // 
            // registration_button
            // 
            this.registration_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registration_button.Location = new System.Drawing.Point(10, 277);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(431, 29);
            this.registration_button.TabIndex = 16;
            this.registration_button.Text = "Регистрация профиля";
            this.registration_button.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 318);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.birthday_label);
            this.Controls.Add(this.post_combobox);
            this.Controls.Add(this.post_label);
            this.Controls.Add(this.validation_panel);
            this.Controls.Add(this.gender_combobox);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.faculty_combobox);
            this.Controls.Add(this.faculty_label);
            this.Controls.Add(this.FIO_label);
            this.Controls.Add(this.FIO_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.birthday_datetime);
            this.Controls.Add(this.login_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrationForm";
            this.Text = "Регистрация профиля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox login_textbox;
        private DateTimePicker birthday_datetime;
        private Label login_label;
        private Label password_label;
        private TextBox password_textbox;
        private Label FIO_label;
        private TextBox FIO_textbox;
        private Label faculty_label;
        private ComboBox faculty_combobox;
        private ComboBox gender_combobox;
        private Label gender_label;
        private Panel validation_panel;
        private ComboBox post_combobox;
        private Label post_label;
        private Label birthday_label;
        private Button registration_button;
    }
}