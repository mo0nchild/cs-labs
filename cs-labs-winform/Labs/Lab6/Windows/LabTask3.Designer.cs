namespace CSharpLabs.Lab6.Windows
{
    partial class LabTask3
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
            this.motos_listview = new System.Windows.Forms.ListView();
            this.motoid_column = new System.Windows.Forms.ColumnHeader();
            this.motoname_column = new System.Windows.Forms.ColumnHeader();
            this.motospeed_column = new System.Windows.Forms.ColumnHeader();
            this.mototype_column = new System.Windows.Forms.ColumnHeader();
            this.motoname_textbox = new System.Windows.Forms.TextBox();
            this.motoname_label = new System.Windows.Forms.Label();
            this.mototype_label = new System.Windows.Forms.Label();
            this.mototype_combobox = new System.Windows.Forms.ComboBox();
            this.motospeed_numeric = new System.Windows.Forms.NumericUpDown();
            this.motospeed_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.motospeed_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // motos_listview
            // 
            this.motos_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.motoid_column,
            this.motoname_column,
            this.motospeed_column,
            this.mototype_column});
            this.motos_listview.Location = new System.Drawing.Point(12, 12);
            this.motos_listview.Name = "motos_listview";
            this.motos_listview.Size = new System.Drawing.Size(255, 254);
            this.motos_listview.TabIndex = 0;
            this.motos_listview.UseCompatibleStateImageBehavior = false;
            this.motos_listview.View = System.Windows.Forms.View.Details;
            // 
            // motoid_column
            // 
            this.motoid_column.Text = "ID";
            this.motoid_column.Width = 40;
            // 
            // motoname_column
            // 
            this.motoname_column.Text = "Name";
            this.motoname_column.Width = 85;
            // 
            // motospeed_column
            // 
            this.motospeed_column.Text = "Speed";
            // 
            // mototype_column
            // 
            this.mototype_column.Text = "Type";
            // 
            // motoname_textbox
            // 
            this.motoname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motoname_textbox.Location = new System.Drawing.Point(273, 34);
            this.motoname_textbox.MaxLength = 100;
            this.motoname_textbox.Name = "motoname_textbox";
            this.motoname_textbox.Size = new System.Drawing.Size(219, 29);
            this.motoname_textbox.TabIndex = 1;
            // 
            // motoname_label
            // 
            this.motoname_label.AutoSize = true;
            this.motoname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motoname_label.Location = new System.Drawing.Point(273, 12);
            this.motoname_label.Name = "motoname_label";
            this.motoname_label.Size = new System.Drawing.Size(145, 19);
            this.motoname_label.TabIndex = 2;
            this.motoname_label.Text = "Название мотоцикла:";
            // 
            // mototype_label
            // 
            this.mototype_label.AutoSize = true;
            this.mototype_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mototype_label.Location = new System.Drawing.Point(273, 66);
            this.mototype_label.Name = "mototype_label";
            this.mototype_label.Size = new System.Drawing.Size(108, 19);
            this.mototype_label.TabIndex = 3;
            this.mototype_label.Text = "Тип мотоцикла:";
            // 
            // mototype_combobox
            // 
            this.mototype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mototype_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mototype_combobox.FormattingEnabled = true;
            this.mototype_combobox.Items.AddRange(new object[] {
            "Scooter",
            "Classic",
            "Sports",
            "Tourer"});
            this.mototype_combobox.Location = new System.Drawing.Point(273, 88);
            this.mototype_combobox.Name = "mototype_combobox";
            this.mototype_combobox.Size = new System.Drawing.Size(219, 29);
            this.mototype_combobox.TabIndex = 4;
            // 
            // motospeed_numeric
            // 
            this.motospeed_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motospeed_numeric.Location = new System.Drawing.Point(273, 143);
            this.motospeed_numeric.Name = "motospeed_numeric";
            this.motospeed_numeric.Size = new System.Drawing.Size(107, 29);
            this.motospeed_numeric.TabIndex = 5;
            // 
            // motospeed_label
            // 
            this.motospeed_label.AutoSize = true;
            this.motospeed_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motospeed_label.Location = new System.Drawing.Point(273, 121);
            this.motospeed_label.Name = "motospeed_label";
            this.motospeed_label.Size = new System.Drawing.Size(71, 19);
            this.motospeed_label.TabIndex = 6;
            this.motospeed_label.Text = "Скорость:";
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(386, 143);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(106, 29);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete_button.Location = new System.Drawing.Point(273, 237);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(219, 29);
            this.delete_button.TabIndex = 8;
            this.delete_button.Text = "Удалить из очереди";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_button.Location = new System.Drawing.Point(273, 202);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(219, 29);
            this.info_button.TabIndex = 9;
            this.info_button.Text = "Получить информацию";
            this.info_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(12, 272);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(480, 29);
            this.exit_button.TabIndex = 10;
            this.exit_button.Text = "Выйти в главное меню";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // LabTask3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.motospeed_label);
            this.Controls.Add(this.motospeed_numeric);
            this.Controls.Add(this.mototype_combobox);
            this.Controls.Add(this.mototype_label);
            this.Controls.Add(this.motoname_label);
            this.Controls.Add(this.motoname_textbox);
            this.Controls.Add(this.motos_listview);
            this.MaximumSize = new System.Drawing.Size(520, 352);
            this.MinimumSize = new System.Drawing.Size(520, 352);
            this.Name = "LabTask3";
            this.Text = "Задание 3";
            ((System.ComponentModel.ISupportInitialize)(this.motospeed_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView motos_listview;
        private ColumnHeader motoid_column;
        private ColumnHeader motoname_column;
        private ColumnHeader motospeed_column;
        private ColumnHeader mototype_column;
        private TextBox motoname_textbox;
        private Label motoname_label;
        private Label mototype_label;
        private ComboBox mototype_combobox;
        private NumericUpDown motospeed_numeric;
        private Label motospeed_label;
        private Button add_button;
        private Button delete_button;
        private Button info_button;
        private Button exit_button;
    }
}