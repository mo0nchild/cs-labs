namespace CSharpLabs.Lab8.Windows
{
    partial class LabTask2
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
            this.exit_button = new System.Windows.Forms.Button();
            this.foldername_textbox = new System.Windows.Forms.TextBox();
            this.rootpath_textbox = new System.Windows.Forms.TextBox();
            this.root_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.foldername_label = new System.Windows.Forms.Label();
            this.rootpath_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 272);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(342, 29);
            this.exit_button.TabIndex = 18;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // foldername_textbox
            // 
            this.foldername_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foldername_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foldername_textbox.Location = new System.Drawing.Point(12, 29);
            this.foldername_textbox.MaxLength = 20;
            this.foldername_textbox.Name = "foldername_textbox";
            this.foldername_textbox.Size = new System.Drawing.Size(342, 29);
            this.foldername_textbox.TabIndex = 19;
            // 
            // rootpath_textbox
            // 
            this.rootpath_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootpath_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rootpath_textbox.Location = new System.Drawing.Point(12, 79);
            this.rootpath_textbox.Name = "rootpath_textbox";
            this.rootpath_textbox.ReadOnly = true;
            this.rootpath_textbox.Size = new System.Drawing.Size(224, 29);
            this.rootpath_textbox.TabIndex = 20;
            // 
            // root_button
            // 
            this.root_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.root_button.Location = new System.Drawing.Point(242, 79);
            this.root_button.Name = "root_button";
            this.root_button.Size = new System.Drawing.Size(112, 29);
            this.root_button.TabIndex = 21;
            this.root_button.Text = "Открыть";
            this.root_button.UseVisualStyleBackColor = true;
            // 
            // create_button
            // 
            this.create_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_button.Location = new System.Drawing.Point(12, 237);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(342, 29);
            this.create_button.TabIndex = 22;
            this.create_button.Text = "Создать папку";
            this.create_button.UseVisualStyleBackColor = true;
            // 
            // foldername_label
            // 
            this.foldername_label.AutoSize = true;
            this.foldername_label.Location = new System.Drawing.Point(12, 11);
            this.foldername_label.Name = "foldername_label";
            this.foldername_label.Size = new System.Drawing.Size(113, 15);
            this.foldername_label.TabIndex = 23;
            this.foldername_label.Text = "Название каталога:";
            // 
            // rootpath_label
            // 
            this.rootpath_label.AutoSize = true;
            this.rootpath_label.Location = new System.Drawing.Point(12, 61);
            this.rootpath_label.Name = "rootpath_label";
            this.rootpath_label.Size = new System.Drawing.Size(146, 15);
            this.rootpath_label.TabIndex = 24;
            this.rootpath_label.Text = "Имя корневого каталога:";
            // 
            // LabTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.rootpath_label);
            this.Controls.Add(this.foldername_label);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.root_button);
            this.Controls.Add(this.rootpath_textbox);
            this.Controls.Add(this.foldername_textbox);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(382, 354);
            this.MinimumSize = new System.Drawing.Size(382, 354);
            this.Name = "LabTask2";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private TextBox foldername_textbox;
        private TextBox rootpath_textbox;
        private Button root_button;
        private Button create_button;
        private Label foldername_label;
        private Label rootpath_label;
    }
}