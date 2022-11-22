namespace CSharpLabs.Lab10.Windows
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.AuthorizateWithLogin = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AuthorizationWithKey = new System.Windows.Forms.Button();
            this.registration_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Для входа по ключу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Логин";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(96, 70);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(172, 23);
            this.LogintextBox.TabIndex = 10;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(96, 114);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(172, 23);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // AuthorizateWithLogin
            // 
            this.AuthorizateWithLogin.Location = new System.Drawing.Point(96, 143);
            this.AuthorizateWithLogin.Name = "AuthorizateWithLogin";
            this.AuthorizateWithLogin.Size = new System.Drawing.Size(75, 23);
            this.AuthorizateWithLogin.TabIndex = 7;
            this.AuthorizateWithLogin.Text = "Войти";
            this.AuthorizateWithLogin.UseVisualStyleBackColor = true;
            this.AuthorizateWithLogin.Click += new System.EventHandler(this.AuthorizateWithLogin_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AuthorizationWithKey
            // 
            this.AuthorizationWithKey.Location = new System.Drawing.Point(139, 203);
            this.AuthorizationWithKey.Name = "AuthorizationWithKey";
            this.AuthorizationWithKey.Size = new System.Drawing.Size(75, 23);
            this.AuthorizationWithKey.TabIndex = 14;
            this.AuthorizationWithKey.Text = "Открыть";
            this.AuthorizationWithKey.UseVisualStyleBackColor = true;
            this.AuthorizationWithKey.Click += new System.EventHandler(this.AuthorizationWithKey_Click);
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(177, 143);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(91, 23);
            this.registration_button.TabIndex = 15;
            this.registration_button.Text = "Регистрация";
            this.registration_button.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 288);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.AuthorizationWithKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.AuthorizateWithLogin);
            this.Name = "AuthorizationForm";
            this.Text = "FindProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox LogintextBox;
        private TextBox PasswordTextBox;
        private Button AuthorizateWithLogin;
        private OpenFileDialog openFileDialog1;
        private Button AuthorizationWithKey;
        private Button registration_button;
    }
}