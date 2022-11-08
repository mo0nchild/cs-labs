namespace CSharpLabs.Lab8.Windows
{
    partial class LabTask3
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
            this.rootpath_label = new System.Windows.Forms.Label();
            this.foldername_label = new System.Windows.Forms.Label();
            this.root_button = new System.Windows.Forms.Button();
            this.rootpath_textbox = new System.Windows.Forms.TextBox();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.method_combobox = new System.Windows.Forms.ComboBox();
            this.method_label = new System.Windows.Forms.Label();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.write_button = new System.Windows.Forms.Button();
            this.message_label = new System.Windows.Forms.Label();
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
            // rootpath_label
            // 
            this.rootpath_label.AutoSize = true;
            this.rootpath_label.Location = new System.Drawing.Point(12, 59);
            this.rootpath_label.Name = "rootpath_label";
            this.rootpath_label.Size = new System.Drawing.Size(146, 15);
            this.rootpath_label.TabIndex = 29;
            this.rootpath_label.Text = "Имя корневого каталога:";
            // 
            // foldername_label
            // 
            this.foldername_label.AutoSize = true;
            this.foldername_label.Location = new System.Drawing.Point(12, 9);
            this.foldername_label.Name = "foldername_label";
            this.foldername_label.Size = new System.Drawing.Size(100, 15);
            this.foldername_label.TabIndex = 28;
            this.foldername_label.Text = "Название файла:";
            // 
            // root_button
            // 
            this.root_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.root_button.Location = new System.Drawing.Point(242, 77);
            this.root_button.Name = "root_button";
            this.root_button.Size = new System.Drawing.Size(112, 29);
            this.root_button.TabIndex = 27;
            this.root_button.Text = "Открыть";
            this.root_button.UseVisualStyleBackColor = true;
            // 
            // rootpath_textbox
            // 
            this.rootpath_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootpath_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rootpath_textbox.Location = new System.Drawing.Point(12, 77);
            this.rootpath_textbox.Name = "rootpath_textbox";
            this.rootpath_textbox.ReadOnly = true;
            this.rootpath_textbox.Size = new System.Drawing.Size(224, 29);
            this.rootpath_textbox.TabIndex = 26;
            // 
            // filename_textbox
            // 
            this.filename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filename_textbox.Location = new System.Drawing.Point(12, 27);
            this.filename_textbox.MaxLength = 20;
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(342, 29);
            this.filename_textbox.TabIndex = 25;
            // 
            // method_combobox
            // 
            this.method_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.method_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.method_combobox.FormattingEnabled = true;
            this.method_combobox.Items.AddRange(new object[] {
            "FileCreate",
            "FileWriteAllText"});
            this.method_combobox.Location = new System.Drawing.Point(12, 127);
            this.method_combobox.Name = "method_combobox";
            this.method_combobox.Size = new System.Drawing.Size(224, 29);
            this.method_combobox.TabIndex = 30;
            // 
            // method_label
            // 
            this.method_label.AutoSize = true;
            this.method_label.Location = new System.Drawing.Point(12, 109);
            this.method_label.Name = "method_label";
            this.method_label.Size = new System.Drawing.Size(98, 15);
            this.method_label.TabIndex = 31;
            this.method_label.Text = "Метод создания:";
            // 
            // message_textbox
            // 
            this.message_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_textbox.Location = new System.Drawing.Point(12, 177);
            this.message_textbox.MaxLength = 200;
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_textbox.Size = new System.Drawing.Size(342, 89);
            this.message_textbox.TabIndex = 32;
            // 
            // write_button
            // 
            this.write_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.write_button.Location = new System.Drawing.Point(242, 126);
            this.write_button.Name = "write_button";
            this.write_button.Size = new System.Drawing.Size(112, 29);
            this.write_button.TabIndex = 33;
            this.write_button.Text = "Записать";
            this.write_button.UseVisualStyleBackColor = true;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(12, 159);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(152, 15);
            this.message_label.TabIndex = 34;
            this.message_label.Text = "Сообщение для отправки:";
            // 
            // LabTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.write_button);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.method_label);
            this.Controls.Add(this.method_combobox);
            this.Controls.Add(this.rootpath_label);
            this.Controls.Add(this.foldername_label);
            this.Controls.Add(this.root_button);
            this.Controls.Add(this.rootpath_textbox);
            this.Controls.Add(this.filename_textbox);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(382, 354);
            this.MinimumSize = new System.Drawing.Size(382, 354);
            this.Name = "LabTask3";
            this.Text = "Задание 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private Label rootpath_label;
        private Label foldername_label;
        private Button root_button;
        private TextBox rootpath_textbox;
        private TextBox filename_textbox;
        private ComboBox method_combobox;
        private Label method_label;
        private TextBox message_textbox;
        private Button write_button;
        private Label message_label;
    }
}