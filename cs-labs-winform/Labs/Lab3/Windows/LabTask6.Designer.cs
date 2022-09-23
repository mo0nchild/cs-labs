namespace CSharpLabs.Lab3.Windows
{
    partial class LabTask6
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
            this.title_label = new System.Windows.Forms.Label();
            this.result_listview = new System.Windows.Forms.ListView();
            this.x_columnheader = new System.Windows.Forms.ColumnHeader();
            this.func_columnheader = new System.Windows.Forms.ColumnHeader();
            this.leftside_numeric = new System.Windows.Forms.NumericUpDown();
            this.rightside_numeric = new System.Windows.Forms.NumericUpDown();
            this.listview_label = new System.Windows.Forms.Label();
            this.leftside_label = new System.Windows.Forms.Label();
            this.rightside_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.calc_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftside_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightside_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(6, 7);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(407, 40);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Задание №6: Вычисление значений функции в каждой точке \r\nотрезка и найти сумму по" +
    "лученных значений.\r\n";
            // 
            // result_listview
            // 
            this.result_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.x_columnheader,
            this.func_columnheader});
            this.result_listview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_listview.FullRowSelect = true;
            this.result_listview.Location = new System.Drawing.Point(12, 86);
            this.result_listview.MultiSelect = false;
            this.result_listview.Name = "result_listview";
            this.result_listview.Size = new System.Drawing.Size(222, 137);
            this.result_listview.TabIndex = 4;
            this.result_listview.UseCompatibleStateImageBehavior = false;
            this.result_listview.View = System.Windows.Forms.View.Details;
            // 
            // x_columnheader
            // 
            this.x_columnheader.Text = "X:";
            // 
            // func_columnheader
            // 
            this.func_columnheader.Text = "Фукнция F(X):";
            this.func_columnheader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.func_columnheader.Width = 160;
            // 
            // leftside_numeric
            // 
            this.leftside_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftside_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftside_numeric.Location = new System.Drawing.Point(245, 86);
            this.leftside_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.leftside_numeric.Name = "leftside_numeric";
            this.leftside_numeric.Size = new System.Drawing.Size(161, 29);
            this.leftside_numeric.TabIndex = 5;
            // 
            // rightside_numeric
            // 
            this.rightside_numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightside_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightside_numeric.Location = new System.Drawing.Point(245, 140);
            this.rightside_numeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rightside_numeric.Name = "rightside_numeric";
            this.rightside_numeric.Size = new System.Drawing.Size(161, 29);
            this.rightside_numeric.TabIndex = 6;
            // 
            // listview_label
            // 
            this.listview_label.AutoSize = true;
            this.listview_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listview_label.Location = new System.Drawing.Point(12, 64);
            this.listview_label.Name = "listview_label";
            this.listview_label.Size = new System.Drawing.Size(191, 19);
            this.listview_label.TabIndex = 7;
            this.listview_label.Text = "Список значений интервала:";
            // 
            // leftside_label
            // 
            this.leftside_label.AutoSize = true;
            this.leftside_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.leftside_label.Location = new System.Drawing.Point(245, 64);
            this.leftside_label.Name = "leftside_label";
            this.leftside_label.Size = new System.Drawing.Size(104, 19);
            this.leftside_label.TabIndex = 8;
            this.leftside_label.Text = "Левая граница:";
            // 
            // rightside_label
            // 
            this.rightside_label.AutoSize = true;
            this.rightside_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rightside_label.Location = new System.Drawing.Point(245, 118);
            this.rightside_label.Name = "rightside_label";
            this.rightside_label.Size = new System.Drawing.Size(113, 19);
            this.rightside_label.TabIndex = 9;
            this.rightside_label.Text = "Правая граница:";
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(245, 194);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(161, 29);
            this.result_textbox.TabIndex = 10;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.Location = new System.Drawing.Point(245, 172);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(132, 19);
            this.result_label.TabIndex = 11;
            this.result_label.Text = "Сумма результатов";
            // 
            // calc_button
            // 
            this.calc_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calc_button.Location = new System.Drawing.Point(12, 233);
            this.calc_button.Name = "calc_button";
            this.calc_button.Size = new System.Drawing.Size(394, 32);
            this.calc_button.TabIndex = 12;
            this.calc_button.Text = "Вычислить результат ряда";
            this.calc_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 291);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(394, 32);
            this.exit_button.TabIndex = 13;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // LabTask6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.calc_button);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.rightside_label);
            this.Controls.Add(this.leftside_label);
            this.Controls.Add(this.listview_label);
            this.Controls.Add(this.rightside_numeric);
            this.Controls.Add(this.leftside_numeric);
            this.Controls.Add(this.result_listview);
            this.Controls.Add(this.title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 6";
            ((System.ComponentModel.ISupportInitialize)(this.leftside_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightside_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title_label;
        private ListView result_listview;
        private NumericUpDown leftside_numeric;
        private NumericUpDown rightside_numeric;
        private Label listview_label;
        private Label leftside_label;
        private Label rightside_label;
        private TextBox result_textbox;
        private Label result_label;
        private Button calc_button;
        private ColumnHeader x_columnheader;
        private ColumnHeader func_columnheader;
        private Button exit_button;
    }
}