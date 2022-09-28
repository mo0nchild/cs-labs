namespace CSharpLabs.Lab3.Windows
{
    partial class LabTask7
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
            this.value_label = new System.Windows.Forms.Label();
            this.value_textbox = new System.Windows.Forms.TextBox();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.oprimazed_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // task1_title_label
            // 
            this.task1_title_label.AutoSize = true;
            this.task1_title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task1_title_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task1_title_label.Location = new System.Drawing.Point(11, 7);
            this.task1_title_label.Name = "task1_title_label";
            this.task1_title_label.Size = new System.Drawing.Size(397, 40);
            this.task1_title_label.TabIndex = 4;
            this.task1_title_label.Text = "Задание №7: Дано целое число N. Выбросить из его записи \r\nцифры 0 и 5, сохранив п" +
    "режний порядок остальных цифр.\r\n";
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_label.Location = new System.Drawing.Point(12, 62);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(87, 19);
            this.value_label.TabIndex = 10;
            this.value_label.Text = "Значение N:";
            // 
            // value_textbox
            // 
            this.value_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_textbox.Location = new System.Drawing.Point(12, 84);
            this.value_textbox.Name = "value_textbox";
            this.value_textbox.Size = new System.Drawing.Size(193, 29);
            this.value_textbox.TabIndex = 11;
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(215, 84);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(193, 29);
            this.result_textbox.TabIndex = 13;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.Location = new System.Drawing.Point(215, 62);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(73, 19);
            this.result_label.TabIndex = 12;
            this.result_label.Text = "Результат:";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(14, 291);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(394, 32);
            this.exit_button.TabIndex = 14;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // oprimazed_checkbox
            // 
            this.oprimazed_checkbox.AutoSize = true;
            this.oprimazed_checkbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oprimazed_checkbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oprimazed_checkbox.Location = new System.Drawing.Point(16, 128);
            this.oprimazed_checkbox.Name = "oprimazed_checkbox";
            this.oprimazed_checkbox.Size = new System.Drawing.Size(133, 23);
            this.oprimazed_checkbox.TabIndex = 15;
            this.oprimazed_checkbox.Text = "Оптимизировать";
            this.oprimazed_checkbox.UseVisualStyleBackColor = true;
            // 
            // LabTask7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.oprimazed_checkbox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.value_textbox);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.task1_title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label task1_title_label;
        private Label value_label;
        private TextBox value_textbox;
        private TextBox result_textbox;
        private Label result_label;
        private Button exit_button;
        private CheckBox oprimazed_checkbox;
    }
}