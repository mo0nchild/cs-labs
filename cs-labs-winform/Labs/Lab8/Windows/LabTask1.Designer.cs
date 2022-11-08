namespace CSharpLabs.Lab8.Windows
{
    partial class LabTask1
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
            this.values_listbox = new System.Windows.Forms.ListBox();
            this.double_numeric = new System.Windows.Forms.NumericUpDown();
            this.add_button = new System.Windows.Forms.Button();
            this.calc_button = new System.Windows.Forms.Button();
            this.values_label = new System.Windows.Forms.Label();
            this.double_label = new System.Windows.Forms.Label();
            this.remove_button = new System.Windows.Forms.Button();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.filename_textbox = new System.Windows.Forms.TextBox();
            this.file_button = new System.Windows.Forms.Button();
            this.filename_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.double_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 274);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(342, 29);
            this.exit_button.TabIndex = 18;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // values_listbox
            // 
            this.values_listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.values_listbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.values_listbox.FormattingEnabled = true;
            this.values_listbox.ItemHeight = 17;
            this.values_listbox.Location = new System.Drawing.Point(12, 27);
            this.values_listbox.Name = "values_listbox";
            this.values_listbox.Size = new System.Drawing.Size(182, 104);
            this.values_listbox.TabIndex = 19;
            // 
            // double_numeric
            // 
            this.double_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.double_numeric.DecimalPlaces = 2;
            this.double_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.double_numeric.Location = new System.Drawing.Point(200, 27);
            this.double_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.double_numeric.Name = "double_numeric";
            this.double_numeric.Size = new System.Drawing.Size(154, 29);
            this.double_numeric.TabIndex = 20;
            this.double_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(200, 67);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(154, 29);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(12, 239);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(342, 29);
            this.calc_button.TabIndex = 22;
            this.calc_button.Text = "Записать и вычислить";
            this.calc_button.UseVisualStyleBackColor = true;
            // 
            // values_label
            // 
            this.values_label.AutoSize = true;
            this.values_label.Location = new System.Drawing.Point(12, 9);
            this.values_label.Name = "values_label";
            this.values_label.Size = new System.Drawing.Size(106, 15);
            this.values_label.TabIndex = 23;
            this.values_label.Text = "Список значений:";
            // 
            // double_label
            // 
            this.double_label.AutoSize = true;
            this.double_label.Location = new System.Drawing.Point(200, 9);
            this.double_label.Name = "double_label";
            this.double_label.Size = new System.Drawing.Size(63, 15);
            this.double_label.TabIndex = 24;
            this.double_label.Text = "Значение:";
            // 
            // remove_button
            // 
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_button.Location = new System.Drawing.Point(200, 102);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(154, 29);
            this.remove_button.TabIndex = 25;
            this.remove_button.Text = "Удалить";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(12, 200);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(342, 29);
            this.result_textbox.TabIndex = 26;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(12, 182);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(63, 15);
            this.result_label.TabIndex = 27;
            this.result_label.Text = "Результат:";
            // 
            // filename_textbox
            // 
            this.filename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filename_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filename_textbox.Location = new System.Drawing.Point(12, 150);
            this.filename_textbox.MaxLength = 100;
            this.filename_textbox.Name = "filename_textbox";
            this.filename_textbox.Size = new System.Drawing.Size(182, 29);
            this.filename_textbox.TabIndex = 28;
            // 
            // file_button
            // 
            this.file_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.file_button.Location = new System.Drawing.Point(200, 150);
            this.file_button.Name = "file_button";
            this.file_button.Size = new System.Drawing.Size(154, 29);
            this.file_button.TabIndex = 29;
            this.file_button.Text = "Каталог";
            this.file_button.UseVisualStyleBackColor = true;
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Location = new System.Drawing.Point(12, 132);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(100, 15);
            this.filename_label.TabIndex = 30;
            this.filename_label.Text = "Название файла:";
            // 
            // LabTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.file_button);
            this.Controls.Add(this.filename_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.double_label);
            this.Controls.Add(this.values_label);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.double_numeric);
            this.Controls.Add(this.values_listbox);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(382, 354);
            this.MinimumSize = new System.Drawing.Size(382, 354);
            this.Name = "LabTask1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.double_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private ListBox values_listbox;
        private NumericUpDown double_numeric;
        private Button add_button;
        private Button calc_button;
        private Label values_label;
        private Label double_label;
        private Button remove_button;
        private TextBox result_textbox;
        private Label result_label;
        private TextBox filename_textbox;
        private Button file_button;
        private Label filename_label;
    }
}