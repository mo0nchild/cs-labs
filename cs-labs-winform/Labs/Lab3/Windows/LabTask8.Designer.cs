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
            this.Calculate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.N_value = new System.Windows.Forms.Label();
            this.Result_value = new System.Windows.Forms.Label();
            this.Result_v = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(13, 180);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Посчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 73);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 7;
            // 
            // N_value
            // 
            this.N_value.AutoSize = true;
            this.N_value.Location = new System.Drawing.Point(12, 75);
            this.N_value.Name = "N_value";
            this.N_value.Size = new System.Drawing.Size(57, 15);
            this.N_value.TabIndex = 8;
            this.N_value.Text = "Число N:";
            // 
            // Result_value
            // 
            this.Result_value.AutoSize = true;
            this.Result_value.Location = new System.Drawing.Point(12, 127);
            this.Result_value.Name = "Result_value";
            this.Result_value.Size = new System.Drawing.Size(63, 15);
            this.Result_value.TabIndex = 9;
            this.Result_value.Text = "Результат:";
            // 
            // Result_v
            // 
            this.Result_v.Location = new System.Drawing.Point(93, 124);
            this.Result_v.Name = "Result_v";
            this.Result_v.ReadOnly = true;
            this.Result_v.Size = new System.Drawing.Size(120, 23);
            this.Result_v.TabIndex = 10;
            // 
            // LabTask8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.Result_v);
            this.Controls.Add(this.Result_value);
            this.Controls.Add(this.N_value);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.task1_title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 8";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label task1_title_label;
        private Button Calculate;
        private NumericUpDown numericUpDown1;
        private Label N_value;
        private Label Result_value;
        private TextBox Result_v;
    }
}