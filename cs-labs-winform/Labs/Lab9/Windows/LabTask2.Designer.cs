namespace CSharpLabs.Lab9.Windows
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
            this.add_button = new System.Windows.Forms.Button();
            this.add_label = new System.Windows.Forms.Label();
            this.values_listbox = new System.Windows.Forms.ListBox();
            this.values_label = new System.Windows.Forms.Label();
            this.filedata_textbox = new System.Windows.Forms.TextBox();
            this.filedata_label = new System.Windows.Forms.Label();
            this.add_numeric = new System.Windows.Forms.NumericUpDown();
            this.save_button = new System.Windows.Forms.Button();
            this.offset_numeric = new System.Windows.Forms.NumericUpDown();
            this.offset_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_numeric = new System.Windows.Forms.NumericUpDown();
            this.remove_button = new System.Windows.Forms.Button();
            this.product_label = new System.Windows.Forms.Label();
            this.product_textbox = new System.Windows.Forms.TextBox();
            this.summary_textbox = new System.Windows.Forms.TextBox();
            this.summary_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.add_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_numeric)).BeginInit();
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
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(276, 27);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(35, 29);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // add_label
            // 
            this.add_label.AutoSize = true;
            this.add_label.Location = new System.Drawing.Point(186, 9);
            this.add_label.Name = "add_label";
            this.add_label.Size = new System.Drawing.Size(63, 15);
            this.add_label.TabIndex = 23;
            this.add_label.Text = "Значение:";
            // 
            // values_listbox
            // 
            this.values_listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.values_listbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.values_listbox.FormattingEnabled = true;
            this.values_listbox.ItemHeight = 17;
            this.values_listbox.Location = new System.Drawing.Point(12, 27);
            this.values_listbox.Name = "values_listbox";
            this.values_listbox.Size = new System.Drawing.Size(159, 121);
            this.values_listbox.TabIndex = 24;
            // 
            // values_label
            // 
            this.values_label.AutoSize = true;
            this.values_label.Location = new System.Drawing.Point(12, 9);
            this.values_label.Name = "values_label";
            this.values_label.Size = new System.Drawing.Size(106, 15);
            this.values_label.TabIndex = 25;
            this.values_label.Text = "Список значений:";
            // 
            // filedata_textbox
            // 
            this.filedata_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filedata_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filedata_textbox.Location = new System.Drawing.Point(12, 169);
            this.filedata_textbox.MaxLength = 20;
            this.filedata_textbox.Multiline = true;
            this.filedata_textbox.Name = "filedata_textbox";
            this.filedata_textbox.ReadOnly = true;
            this.filedata_textbox.Size = new System.Drawing.Size(341, 41);
            this.filedata_textbox.TabIndex = 26;
            // 
            // filedata_label
            // 
            this.filedata_label.AutoSize = true;
            this.filedata_label.Location = new System.Drawing.Point(12, 151);
            this.filedata_label.Name = "filedata_label";
            this.filedata_label.Size = new System.Drawing.Size(113, 15);
            this.filedata_label.TabIndex = 27;
            this.filedata_label.Text = "Название каталога:";
            // 
            // add_numeric
            // 
            this.add_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.add_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_numeric.Location = new System.Drawing.Point(186, 27);
            this.add_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.add_numeric.Name = "add_numeric";
            this.add_numeric.Size = new System.Drawing.Size(77, 29);
            this.add_numeric.TabIndex = 28;
            this.add_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_button.Location = new System.Drawing.Point(186, 119);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(167, 29);
            this.save_button.TabIndex = 29;
            this.save_button.Text = "Записать данные";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // offset_numeric
            // 
            this.offset_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.offset_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.offset_numeric.Location = new System.Drawing.Point(186, 77);
            this.offset_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.offset_numeric.Name = "offset_numeric";
            this.offset_numeric.Size = new System.Drawing.Size(77, 29);
            this.offset_numeric.TabIndex = 30;
            this.offset_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.offset_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // offset_label
            // 
            this.offset_label.AutoSize = true;
            this.offset_label.Location = new System.Drawing.Point(186, 59);
            this.offset_label.Name = "offset_label";
            this.offset_label.Size = new System.Drawing.Size(58, 15);
            this.offset_label.TabIndex = 31;
            this.offset_label.Text = "Позиция:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Вставить:";
            // 
            // insert_numeric
            // 
            this.insert_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.insert_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insert_numeric.Location = new System.Drawing.Point(276, 77);
            this.insert_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.insert_numeric.Name = "insert_numeric";
            this.insert_numeric.Size = new System.Drawing.Size(77, 29);
            this.insert_numeric.TabIndex = 32;
            this.insert_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remove_button
            // 
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remove_button.Location = new System.Drawing.Point(318, 27);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(35, 29);
            this.remove_button.TabIndex = 34;
            this.remove_button.Text = "-";
            this.remove_button.UseVisualStyleBackColor = true;
            // 
            // product_label
            // 
            this.product_label.AutoSize = true;
            this.product_label.Location = new System.Drawing.Point(12, 213);
            this.product_label.Name = "product_label";
            this.product_label.Size = new System.Drawing.Size(133, 15);
            this.product_label.TabIndex = 35;
            this.product_label.Text = "Квадрат произведения:";
            // 
            // product_textbox
            // 
            this.product_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.product_textbox.Location = new System.Drawing.Point(12, 231);
            this.product_textbox.MaxLength = 20;
            this.product_textbox.Multiline = true;
            this.product_textbox.Name = "product_textbox";
            this.product_textbox.ReadOnly = true;
            this.product_textbox.Size = new System.Drawing.Size(159, 29);
            this.product_textbox.TabIndex = 36;
            // 
            // summary_textbox
            // 
            this.summary_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summary_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summary_textbox.Location = new System.Drawing.Point(194, 231);
            this.summary_textbox.MaxLength = 20;
            this.summary_textbox.Multiline = true;
            this.summary_textbox.Name = "summary_textbox";
            this.summary_textbox.ReadOnly = true;
            this.summary_textbox.Size = new System.Drawing.Size(159, 29);
            this.summary_textbox.TabIndex = 38;
            // 
            // summary_label
            // 
            this.summary_label.AutoSize = true;
            this.summary_label.Location = new System.Drawing.Point(194, 213);
            this.summary_label.Name = "summary_label";
            this.summary_label.Size = new System.Drawing.Size(95, 15);
            this.summary_label.TabIndex = 37;
            this.summary_label.Text = "Модуль суммы:";
            // 
            // LabTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 315);
            this.Controls.Add(this.summary_textbox);
            this.Controls.Add(this.summary_label);
            this.Controls.Add(this.product_textbox);
            this.Controls.Add(this.product_label);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insert_numeric);
            this.Controls.Add(this.offset_label);
            this.Controls.Add(this.offset_numeric);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_numeric);
            this.Controls.Add(this.filedata_label);
            this.Controls.Add(this.filedata_textbox);
            this.Controls.Add(this.values_label);
            this.Controls.Add(this.values_listbox);
            this.Controls.Add(this.add_label);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(382, 354);
            this.MinimumSize = new System.Drawing.Size(382, 354);
            this.Name = "LabTask2";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.add_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offset_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private Button add_button;
        private Label add_label;
        private ListBox values_listbox;
        private Label values_label;
        private TextBox filedata_textbox;
        private Label filedata_label;
        private NumericUpDown add_numeric;
        private Button save_button;
        private NumericUpDown offset_numeric;
        private Label offset_label;
        private Label label2;
        private NumericUpDown insert_numeric;
        private Button remove_button;
        private Label product_label;
        private TextBox product_textbox;
        private TextBox summary_textbox;
        private Label summary_label;
    }
}