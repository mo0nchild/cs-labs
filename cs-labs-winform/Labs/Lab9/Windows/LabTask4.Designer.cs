namespace CSharpLabs.Lab9.Windows
{
    partial class LabTask4
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
            this.filepath_textbox = new System.Windows.Forms.TextBox();
            this.filepath_label = new System.Windows.Forms.Label();
            this.file_button = new System.Windows.Forms.Button();
            this.createtime_textbox = new System.Windows.Forms.TextBox();
            this.createtime_label = new System.Windows.Forms.Label();
            this.accesstime_textbox = new System.Windows.Forms.TextBox();
            this.accesstime_label = new System.Windows.Forms.Label();
            this.writetime_textbox = new System.Windows.Forms.TextBox();
            this.writetime_label = new System.Windows.Forms.Label();
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
            // filepath_textbox
            // 
            this.filepath_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filepath_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filepath_textbox.Location = new System.Drawing.Point(12, 27);
            this.filepath_textbox.MaxLength = 200;
            this.filepath_textbox.Multiline = true;
            this.filepath_textbox.Name = "filepath_textbox";
            this.filepath_textbox.ReadOnly = true;
            this.filepath_textbox.Size = new System.Drawing.Size(254, 29);
            this.filepath_textbox.TabIndex = 41;
            // 
            // filepath_label
            // 
            this.filepath_label.AutoSize = true;
            this.filepath_label.Location = new System.Drawing.Point(12, 9);
            this.filepath_label.Name = "filepath_label";
            this.filepath_label.Size = new System.Drawing.Size(83, 15);
            this.filepath_label.TabIndex = 40;
            this.filepath_label.Text = "Путь к файлу:";
            // 
            // file_button
            // 
            this.file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file_button.Location = new System.Drawing.Point(272, 27);
            this.file_button.Name = "file_button";
            this.file_button.Size = new System.Drawing.Size(82, 29);
            this.file_button.TabIndex = 39;
            this.file_button.Text = "Открыть";
            this.file_button.UseVisualStyleBackColor = true;
            // 
            // createtime_textbox
            // 
            this.createtime_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createtime_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createtime_textbox.Location = new System.Drawing.Point(12, 106);
            this.createtime_textbox.MaxLength = 20;
            this.createtime_textbox.Multiline = true;
            this.createtime_textbox.Name = "createtime_textbox";
            this.createtime_textbox.ReadOnly = true;
            this.createtime_textbox.Size = new System.Drawing.Size(163, 29);
            this.createtime_textbox.TabIndex = 43;
            // 
            // createtime_label
            // 
            this.createtime_label.AutoSize = true;
            this.createtime_label.Location = new System.Drawing.Point(12, 88);
            this.createtime_label.Name = "createtime_label";
            this.createtime_label.Size = new System.Drawing.Size(98, 15);
            this.createtime_label.TabIndex = 42;
            this.createtime_label.Text = "Время создания:";
            // 
            // accesstime_textbox
            // 
            this.accesstime_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accesstime_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accesstime_textbox.Location = new System.Drawing.Point(191, 106);
            this.accesstime_textbox.MaxLength = 20;
            this.accesstime_textbox.Multiline = true;
            this.accesstime_textbox.Name = "accesstime_textbox";
            this.accesstime_textbox.ReadOnly = true;
            this.accesstime_textbox.Size = new System.Drawing.Size(163, 29);
            this.accesstime_textbox.TabIndex = 45;
            // 
            // accesstime_label
            // 
            this.accesstime_label.AutoSize = true;
            this.accesstime_label.Location = new System.Drawing.Point(191, 88);
            this.accesstime_label.Name = "accesstime_label";
            this.accesstime_label.Size = new System.Drawing.Size(158, 15);
            this.accesstime_label.TabIndex = 44;
            this.accesstime_label.Text = "Время последнего доступа:";
            // 
            // writetime_textbox
            // 
            this.writetime_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.writetime_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writetime_textbox.Location = new System.Drawing.Point(12, 156);
            this.writetime_textbox.MaxLength = 20;
            this.writetime_textbox.Multiline = true;
            this.writetime_textbox.Name = "writetime_textbox";
            this.writetime_textbox.ReadOnly = true;
            this.writetime_textbox.Size = new System.Drawing.Size(163, 29);
            this.writetime_textbox.TabIndex = 47;
            // 
            // writetime_label
            // 
            this.writetime_label.AutoSize = true;
            this.writetime_label.Location = new System.Drawing.Point(12, 138);
            this.writetime_label.Name = "writetime_label";
            this.writetime_label.Size = new System.Drawing.Size(148, 15);
            this.writetime_label.TabIndex = 46;
            this.writetime_label.Text = "Время последней записи:";
            // 
            // LabTask4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.writetime_textbox);
            this.Controls.Add(this.writetime_label);
            this.Controls.Add(this.accesstime_textbox);
            this.Controls.Add(this.accesstime_label);
            this.Controls.Add(this.createtime_textbox);
            this.Controls.Add(this.createtime_label);
            this.Controls.Add(this.filepath_textbox);
            this.Controls.Add(this.filepath_label);
            this.Controls.Add(this.file_button);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(382, 354);
            this.MinimumSize = new System.Drawing.Size(382, 354);
            this.Name = "LabTask4";
            this.Text = "Задание 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private TextBox filepath_textbox;
        private Label filepath_label;
        private Button file_button;
        private TextBox createtime_textbox;
        private Label createtime_label;
        private TextBox accesstime_textbox;
        private Label accesstime_label;
        private TextBox writetime_textbox;
        private Label writetime_label;
    }
}