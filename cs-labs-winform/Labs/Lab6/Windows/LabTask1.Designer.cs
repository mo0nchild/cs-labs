namespace CSharpLabs.Lab6.Windows
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
            this.value_label = new System.Windows.Forms.Label();
            this.value_textbox = new System.Windows.Forms.TextBox();
            this.values_listbox = new System.Windows.Forms.ListBox();
            this.operations_listbox = new System.Windows.Forms.ListBox();
            this.add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 272);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(480, 29);
            this.exit_button.TabIndex = 18;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_label.Location = new System.Drawing.Point(12, 189);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(73, 19);
            this.value_label.TabIndex = 12;
            this.value_label.Text = "Значение:";
            // 
            // value_textbox
            // 
            this.value_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_textbox.Location = new System.Drawing.Point(12, 211);
            this.value_textbox.MaxLength = 100;
            this.value_textbox.Name = "value_textbox";
            this.value_textbox.Size = new System.Drawing.Size(230, 29);
            this.value_textbox.TabIndex = 11;
            // 
            // values_listbox
            // 
            this.values_listbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.values_listbox.FormattingEnabled = true;
            this.values_listbox.ItemHeight = 17;
            this.values_listbox.Location = new System.Drawing.Point(12, 12);
            this.values_listbox.Name = "values_listbox";
            this.values_listbox.Size = new System.Drawing.Size(230, 174);
            this.values_listbox.TabIndex = 19;
            // 
            // operations_listbox
            // 
            this.operations_listbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operations_listbox.FormattingEnabled = true;
            this.operations_listbox.ItemHeight = 17;
            this.operations_listbox.Items.AddRange(new object[] {
            "Вызов метода: List.Add",
            "Вызов метода: List.Insert",
            "Вызов метода: List.Remove",
            "Вызов метода: List.Sort",
            "Вызов метода: List.Clear"});
            this.operations_listbox.Location = new System.Drawing.Point(262, 12);
            this.operations_listbox.Name = "operations_listbox";
            this.operations_listbox.Size = new System.Drawing.Size(230, 174);
            this.operations_listbox.TabIndex = 20;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(262, 211);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(230, 29);
            this.add_button.TabIndex = 21;
            this.add_button.Text = "Выполнить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // LabTask1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.operations_listbox);
            this.Controls.Add(this.values_listbox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.value_textbox);
            this.MaximumSize = new System.Drawing.Size(520, 352);
            this.MinimumSize = new System.Drawing.Size(520, 352);
            this.Name = "LabTask1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button exit_button;
        private Label value_label;
        private TextBox value_textbox;
        private ListBox values_listbox;
        private ListBox operations_listbox;
        private Button add_button;
    }
}