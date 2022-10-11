using CSharpLabs.LabsLoader;

namespace CSharpLabs.Lab5.Windows
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
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.calc_button = new System.Windows.Forms.Button();
            this.input_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_textbox.Location = new System.Drawing.Point(22, 30);
            this.input_textbox.MaxLength = 100;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(331, 29);
            this.input_textbox.TabIndex = 0;
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(258, 85);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(95, 31);
            this.calc_button.TabIndex = 1;
            this.calc_button.Text = "Вычислить";
            this.calc_button.UseVisualStyleBackColor = true;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_label.Location = new System.Drawing.Point(22, 9);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(110, 19);
            this.input_label.TabIndex = 2;
            this.input_label.Text = "Входная строка:";
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(22, 87);
            this.result_textbox.MaxLength = 100;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(220, 29);
            this.result_textbox.TabIndex = 3;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.Location = new System.Drawing.Point(22, 65);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(73, 19);
            this.result_label.TabIndex = 4;
            this.result_label.Text = "Результат:";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(22, 222);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(331, 31);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Вернуться в меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // LabTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 268);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.input_textbox);
            this.MaximumSize = new System.Drawing.Size(384, 307);
            this.MinimumSize = new System.Drawing.Size(384, 307);
            this.Name = "LabTask1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_textbox;
        private Button calc_button;
        private Label input_label;
        private TextBox result_textbox;
        private Label result_label;
        private Button exit_button;
    }
}