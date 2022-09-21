namespace CSharpLabs.Windows
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_label = new System.Windows.Forms.Label();
            this.info_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.task_combobox = new System.Windows.Forms.ComboBox();
            this.theme_label = new System.Windows.Forms.Label();
            this.task_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main_label
            // 
            this.main_label.AutoSize = true;
            this.main_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_label.Location = new System.Drawing.Point(103, 9);
            this.main_label.Name = "main_label";
            this.main_label.Size = new System.Drawing.Size(241, 25);
            this.main_label.TabIndex = 1;
            this.main_label.Text = "Лабораторная работа №2";
            this.main_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_button.Location = new System.Drawing.Point(14, 176);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(303, 32);
            this.info_button.TabIndex = 2;
            this.info_button.Text = "Информация лабораторной работы ";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // help_button
            // 
            this.help_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.help_button.Location = new System.Drawing.Point(336, 130);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(107, 32);
            this.help_button.TabIndex = 3;
            this.help_button.Text = "Описание";
            this.help_button.UseVisualStyleBackColor = true;
            this.help_button.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(186, 130);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(131, 32);
            this.start_button.TabIndex = 4;
            this.start_button.Text = "Запуск задания";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // task_combobox
            // 
            this.task_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.task_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.task_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task_combobox.FormattingEnabled = true;
            this.task_combobox.Items.AddRange(new object[] {
            "Задание 1",
            "Задание 2"});
            this.task_combobox.Location = new System.Drawing.Point(14, 133);
            this.task_combobox.Name = "task_combobox";
            this.task_combobox.Size = new System.Drawing.Size(149, 29);
            this.task_combobox.TabIndex = 5;
            // 
            // theme_label
            // 
            this.theme_label.AutoSize = true;
            this.theme_label.BackColor = System.Drawing.Color.White;
            this.theme_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theme_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.theme_label.Location = new System.Drawing.Point(12, 43);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(431, 59);
            this.theme_label.TabIndex = 0;
            this.theme_label.Text = "«Разработка визуальных пользовательских интерфейсов для \r\nпрограммирования ввода-" +
    "вывода и основных операторов языка \r\nC# на платформе .NET Framework»";
            this.theme_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task_label
            // 
            this.task_label.AutoSize = true;
            this.task_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task_label.Location = new System.Drawing.Point(14, 111);
            this.task_label.Name = "task_label";
            this.task_label.Size = new System.Drawing.Size(127, 19);
            this.task_label.TabIndex = 6;
            this.task_label.Text = "Перечень заданий";
            this.task_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(336, 176);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(107, 32);
            this.exit_button.TabIndex = 7;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 230);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.task_label);
            this.Controls.Add(this.task_combobox);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.main_label);
            this.Controls.Add(this.theme_label);
            this.MaximumSize = new System.Drawing.Size(468, 269);
            this.MinimumSize = new System.Drawing.Size(468, 269);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label main_label;
        private Button info_button;
        private Button help_button;
        private Button start_button;
        private ComboBox task_combobox;
        private Label theme_label;
        private Label task_label;
        private Button exit_button;
    }
}