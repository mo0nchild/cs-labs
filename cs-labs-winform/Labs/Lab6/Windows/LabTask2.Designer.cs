namespace CSharpLabs.Lab6.Windows
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
            this.L2_exit_button = new System.Windows.Forms.Button();
            this.L2_motos_listview = new System.Windows.Forms.ListView();
            this.motoid_column = new System.Windows.Forms.ColumnHeader();
            this.motoname_column = new System.Windows.Forms.ColumnHeader();
            this.motospeedMax_column = new System.Windows.Forms.ColumnHeader();
            this.mototype_column = new System.Windows.Forms.ColumnHeader();
            this.motospeed_column = new System.Windows.Forms.ColumnHeader();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditItem = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.L2_Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.L2_moto_delete = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.L2_add_button = new System.Windows.Forms.Button();
            this.motospeed_label = new System.Windows.Forms.Label();
            this.motospeed_numeric = new System.Windows.Forms.NumericUpDown();
            this.L2_mototype_combobox = new System.Windows.Forms.ComboBox();
            this.mototype_label = new System.Windows.Forms.Label();
            this.motoname_label = new System.Windows.Forms.Label();
            this.L2_motoname_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motospeed_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // L2_exit_button
            // 
            this.L2_exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L2_exit_button.Location = new System.Drawing.Point(12, 272);
            this.L2_exit_button.Name = "L2_exit_button";
            this.L2_exit_button.Size = new System.Drawing.Size(480, 29);
            this.L2_exit_button.TabIndex = 21;
            this.L2_exit_button.Text = "Выйти в главное меню";
            this.L2_exit_button.UseVisualStyleBackColor = true;
            this.L2_exit_button.Click += new System.EventHandler(this.L2_exit_button_Click);
            // 
            // L2_motos_listview
            // 
            this.L2_motos_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.motoid_column,
            this.motoname_column,
            this.motospeedMax_column,
            this.mototype_column,
            this.motospeed_column});
            this.L2_motos_listview.FullRowSelect = true;
            this.L2_motos_listview.GridLines = true;
            this.L2_motos_listview.Location = new System.Drawing.Point(12, 12);
            this.L2_motos_listview.MultiSelect = false;
            this.L2_motos_listview.Name = "L2_motos_listview";
            this.L2_motos_listview.Size = new System.Drawing.Size(257, 254);
            this.L2_motos_listview.TabIndex = 11;
            this.L2_motos_listview.UseCompatibleStateImageBehavior = false;
            this.L2_motos_listview.View = System.Windows.Forms.View.Details;
            this.L2_motos_listview.Click += new System.EventHandler(this.L2_motos_listview_Click);
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
            // motospeedMax_column
            // 
            this.motospeedMax_column.Text = "Max Speed";
            // 
            // mototype_column
            // 
            this.mototype_column.Text = "Type";
            // 
            // motospeed_column
            // 
            this.motospeed_column.Text = "Speed";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(275, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(217, 254);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditItem);
            this.tabPage1.Controls.Add(this.propertyGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(209, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изменить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditItem
            // 
            this.EditItem.Location = new System.Drawing.Point(3, 200);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(200, 23);
            this.EditItem.TabIndex = 1;
            this.EditItem.Text = "Обновить";
            this.EditItem.UseVisualStyleBackColor = true;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(3, 6);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(200, 186);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.L2_Change);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.L2_moto_delete);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.L2_add_button);
            this.tabPage2.Controls.Add(this.motospeed_label);
            this.tabPage2.Controls.Add(this.motospeed_numeric);
            this.tabPage2.Controls.Add(this.L2_mototype_combobox);
            this.tabPage2.Controls.Add(this.mototype_label);
            this.tabPage2.Controls.Add(this.motoname_label);
            this.tabPage2.Controls.Add(this.L2_motoname_textbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(209, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // L2_Change
            // 
            this.L2_Change.Location = new System.Drawing.Point(116, 187);
            this.L2_Change.Name = "L2_Change";
            this.L2_Change.Size = new System.Drawing.Size(87, 33);
            this.L2_Change.TabIndex = 39;
            this.L2_Change.Text = "Изменить";
            this.L2_Change.UseVisualStyleBackColor = true;
            this.L2_Change.Click += new System.EventHandler(this.L2_Change_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Скорость:";
            // 
            // L2_moto_delete
            // 
            this.L2_moto_delete.Location = new System.Drawing.Point(116, 78);
            this.L2_moto_delete.Name = "L2_moto_delete";
            this.L2_moto_delete.Size = new System.Drawing.Size(87, 30);
            this.L2_moto_delete.TabIndex = 36;
            this.L2_moto_delete.Text = "Удалить";
            this.L2_moto_delete.UseVisualStyleBackColor = true;
            this.L2_moto_delete.Click += new System.EventHandler(this.L2_moto_delete_Click_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(4, 187);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(88, 29);
            this.numericUpDown2.TabIndex = 37;
            // 
            // L2_add_button
            // 
            this.L2_add_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L2_add_button.Location = new System.Drawing.Point(116, 134);
            this.L2_add_button.Name = "L2_add_button";
            this.L2_add_button.Size = new System.Drawing.Size(87, 32);
            this.L2_add_button.TabIndex = 35;
            this.L2_add_button.Text = "Добавить";
            this.L2_add_button.UseVisualStyleBackColor = true;
            this.L2_add_button.Click += new System.EventHandler(this.L2_add_button_Click_1);
            // 
            // motospeed_label
            // 
            this.motospeed_label.AutoSize = true;
            this.motospeed_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motospeed_label.Location = new System.Drawing.Point(3, 112);
            this.motospeed_label.Name = "motospeed_label";
            this.motospeed_label.Size = new System.Drawing.Size(169, 19);
            this.motospeed_label.TabIndex = 34;
            this.motospeed_label.Text = "Максимальная Скорость:";
            // 
            // motospeed_numeric
            // 
            this.motospeed_numeric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motospeed_numeric.Location = new System.Drawing.Point(4, 134);
            this.motospeed_numeric.Name = "motospeed_numeric";
            this.motospeed_numeric.Size = new System.Drawing.Size(88, 29);
            this.motospeed_numeric.TabIndex = 33;
            // 
            // L2_mototype_combobox
            // 
            this.L2_mototype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.L2_mototype_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L2_mototype_combobox.FormattingEnabled = true;
            this.L2_mototype_combobox.Items.AddRange(new object[] {
            "Scooter",
            "Classic",
            "Sports",
            "Tourer"});
            this.L2_mototype_combobox.Location = new System.Drawing.Point(3, 79);
            this.L2_mototype_combobox.Name = "L2_mototype_combobox";
            this.L2_mototype_combobox.Size = new System.Drawing.Size(108, 29);
            this.L2_mototype_combobox.TabIndex = 32;
            // 
            // mototype_label
            // 
            this.mototype_label.AutoSize = true;
            this.mototype_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mototype_label.Location = new System.Drawing.Point(3, 57);
            this.mototype_label.Name = "mototype_label";
            this.mototype_label.Size = new System.Drawing.Size(108, 19);
            this.mototype_label.TabIndex = 31;
            this.mototype_label.Text = "Тип мотоцикла:";
            // 
            // motoname_label
            // 
            this.motoname_label.AutoSize = true;
            this.motoname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.motoname_label.Location = new System.Drawing.Point(3, 3);
            this.motoname_label.Name = "motoname_label";
            this.motoname_label.Size = new System.Drawing.Size(145, 19);
            this.motoname_label.TabIndex = 30;
            this.motoname_label.Text = "Название мотоцикла:";
            // 
            // L2_motoname_textbox
            // 
            this.L2_motoname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L2_motoname_textbox.Location = new System.Drawing.Point(3, 25);
            this.L2_motoname_textbox.MaxLength = 100;
            this.L2_motoname_textbox.Name = "L2_motoname_textbox";
            this.L2_motoname_textbox.Size = new System.Drawing.Size(200, 29);
            this.L2_motoname_textbox.TabIndex = 29;
            // 
            // LabTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 313);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.L2_exit_button);
            this.Controls.Add(this.L2_motos_listview);
            this.MaximumSize = new System.Drawing.Size(520, 352);
            this.MinimumSize = new System.Drawing.Size(520, 352);
            this.Name = "LabTask2";
            this.Text = "Задание 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motospeed_numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button L2_exit_button;
        private ListView L2_motos_listview;
        private ColumnHeader motoid_column;
        private ColumnHeader motoname_column;
        private ColumnHeader motospeedMax_column;
        private ColumnHeader mototype_column;
        private ColumnHeader motospeed_column;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private PropertyGrid propertyGrid1;
        private TabPage tabPage2;
        private Button L2_Change;
        private Label label1;
        private Button L2_moto_delete;
        private NumericUpDown numericUpDown2;
        private Button L2_add_button;
        private Label motospeed_label;
        private NumericUpDown motospeed_numeric;
        private ComboBox L2_mototype_combobox;
        private Label mototype_label;
        private Label motoname_label;
        private TextBox L2_motoname_textbox;
        private Button EditItem;
    }
}