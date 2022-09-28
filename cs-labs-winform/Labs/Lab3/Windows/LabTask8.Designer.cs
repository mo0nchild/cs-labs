namespace CSharpLabs.Lab3.Windows
{
    partial class LabTask8
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
            this.calc_button = new System.Windows.Forms.Button();
            this.value_numeric = new System.Windows.Forms.NumericUpDown();
            this.value_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.value_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // task1_title_label
            // 
            this.task1_title_label.AutoSize = true;
            this.task1_title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task1_title_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task1_title_label.Location = new System.Drawing.Point(13, 7);
            this.task1_title_label.Name = "task1_title_label";
            this.task1_title_label.Size = new System.Drawing.Size(392, 40);
            this.task1_title_label.TabIndex = 5;
            this.task1_title_label.Text = "Задание №8: Дано целое число N>0. Используя один цикл,\r\nнайти сумму 1! +2! + 3! +" +
    "...+N!\r\n";
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(13, 126);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(393, 32);
            this.calc_button.TabIndex = 6;
            this.calc_button.Text = "Посчитать";
            this.calc_button.UseVisualStyleBackColor = true;
            this.calc_button.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // value_numeric
            // 
            this.value_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_numeric.Location = new System.Drawing.Point(13, 82);
            this.value_numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.value_numeric.Name = "value_numeric";
            this.value_numeric.Size = new System.Drawing.Size(183, 29);
            this.value_numeric.TabIndex = 7;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_label.Location = new System.Drawing.Point(13, 60);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(64, 19);
            this.value_label.TabIndex = 8;
            this.value_label.Text = "Число N:";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.Location = new System.Drawing.Point(212, 60);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(73, 19);
            this.result_label.TabIndex = 9;
            this.result_label.Text = "Результат:";
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(212, 82);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(194, 29);
            this.result_textbox.TabIndex = 10;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(11, 291);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(394, 32);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // LabTask8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.value_numeric);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.task1_title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 8";
            ((System.ComponentModel.ISupportInitialize)(this.value_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label task1_title_label;
        private Button calc_button;
        private NumericUpDown value_numeric;
        private Label value_label;
        private Label result_label;
        private TextBox result_textbox;
        private Button exit_button;
    }
}