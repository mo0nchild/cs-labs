namespace CSharpLabs.Lab8.Windows
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
            this.rootpath_label = new System.Windows.Forms.Label();
            this.root_button = new System.Windows.Forms.Button();
            this.rootpath_textbox = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.message_textbox = new System.Windows.Forms.TextBox();
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
            this.rootpath_label.Location = new System.Drawing.Point(12, 9);
            this.rootpath_label.Name = "rootpath_label";
            this.rootpath_label.Size = new System.Drawing.Size(72, 15);
            this.rootpath_label.TabIndex = 36;
            this.rootpath_label.Text = "Имя файла:";
            // 
            // root_button
            // 
            this.root_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.root_button.Location = new System.Drawing.Point(242, 27);
            this.root_button.Name = "root_button";
            this.root_button.Size = new System.Drawing.Size(112, 29);
            this.root_button.TabIndex = 34;
            this.root_button.Text = "Открыть";
            this.root_button.UseVisualStyleBackColor = true;
            // 
            // rootpath_textbox
            // 
            this.rootpath_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootpath_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rootpath_textbox.Location = new System.Drawing.Point(12, 27);
            this.rootpath_textbox.Name = "rootpath_textbox";
            this.rootpath_textbox.ReadOnly = true;
            this.rootpath_textbox.Size = new System.Drawing.Size(224, 29);
            this.rootpath_textbox.TabIndex = 33;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Location = new System.Drawing.Point(12, 59);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(76, 15);
            this.message_label.TabIndex = 38;
            this.message_label.Text = "Сообщение:";
            // 
            // message_textbox
            // 
            this.message_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.message_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.message_textbox.Location = new System.Drawing.Point(12, 77);
            this.message_textbox.MaxLength = 200;
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.ReadOnly = true;
            this.message_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message_textbox.Size = new System.Drawing.Size(342, 189);
            this.message_textbox.TabIndex = 37;
            // 
            // LabTask4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.rootpath_label);
            this.Controls.Add(this.root_button);
            this.Controls.Add(this.rootpath_textbox);
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
        private Label rootpath_label;
        private Button root_button;
        private TextBox rootpath_textbox;
        private Label message_label;
        private TextBox message_textbox;
    }
}