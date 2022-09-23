namespace CSharpLabs.Lab3.Windows
{
    partial class LabTask5
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
            this.task1_title_label = new System.Windows.Forms.Label();
            this.value_e_numeric = new System.Windows.Forms.NumericUpDown();
            this.value_e_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.value_e_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // task1_title_label
            // 
            this.task1_title_label.AutoSize = true;
            this.task1_title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task1_title_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task1_title_label.Location = new System.Drawing.Point(6, 7);
            this.task1_title_label.Name = "task1_title_label";
            this.task1_title_label.Size = new System.Drawing.Size(406, 40);
            this.task1_title_label.TabIndex = 2;
            this.task1_title_label.Text = "Задание №5: Найти сумму бесконечного ряда. Суммировать \r\nпока члены ряда не стану" +
    "т меньше заданного E>0.\r\n";
            // 
            // value_e_numeric
            // 
            this.value_e_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_e_numeric.DecimalPlaces = 2;
            this.value_e_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_e_numeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.value_e_numeric.Location = new System.Drawing.Point(12, 88);
            this.value_e_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.value_e_numeric.Name = "value_e_numeric";
            this.value_e_numeric.Size = new System.Drawing.Size(161, 29);
            this.value_e_numeric.TabIndex = 3;
            this.value_e_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // value_e_label
            // 
            this.value_e_label.AutoSize = true;
            this.value_e_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_e_label.Location = new System.Drawing.Point(12, 66);
            this.value_e_label.Name = "value_e_label";
            this.value_e_label.Size = new System.Drawing.Size(84, 19);
            this.value_e_label.TabIndex = 4;
            this.value_e_label.Text = "Значение E:";
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(189, 88);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(217, 29);
            this.result_textbox.TabIndex = 5;
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(12, 132);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(394, 32);
            this.calc_button.TabIndex = 6;
            this.calc_button.Text = "Вычислить результат ряда";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.calc_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Результат:";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 291);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(394, 32);
            this.exit_button.TabIndex = 14;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // LabTask5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.value_e_label);
            this.Controls.Add(this.value_e_numeric);
            this.Controls.Add(this.task1_title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 5";
            ((System.ComponentModel.ISupportInitialize)(this.value_e_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label task1_title_label;
        private NumericUpDown value_e_numeric;
        private Label value_e_label;
        private TextBox result_textbox;
        private Button calc_button;
        private Label label1;
        private Button exit_button;
    }
}