namespace CSharpLabs.Windows
{
    partial class Create_Form
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
            this.Model_value = new System.Windows.Forms.ComboBox();
            this.max_speed_value = new System.Windows.Forms.NumericUpDown();
            this.Model_C = new System.Windows.Forms.Label();
            this.Max_Speed_C = new System.Windows.Forms.Label();
            this.Create_Moto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.max_speed_value)).BeginInit();
            this.SuspendLayout();
            // 
            // Model_value
            // 
            this.Model_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Model_value.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Model_value.FormattingEnabled = true;
            this.Model_value.Items.AddRange(new object[] {
            "classic",
            "adventure",
            "scooter",
            "sports"});
            this.Model_value.Location = new System.Drawing.Point(156, 17);
            this.Model_value.Name = "Model_value";
            this.Model_value.Size = new System.Drawing.Size(116, 23);
            this.Model_value.TabIndex = 0;
            // 
            // max_speed_value
            // 
            this.max_speed_value.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.max_speed_value.Location = new System.Drawing.Point(156, 46);
            this.max_speed_value.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.max_speed_value.Name = "max_speed_value";
            this.max_speed_value.Size = new System.Drawing.Size(116, 23);
            this.max_speed_value.TabIndex = 1;
            // 
            // Model_C
            // 
            this.Model_C.AutoSize = true;
            this.Model_C.Location = new System.Drawing.Point(12, 20);
            this.Model_C.Name = "Model_C";
            this.Model_C.Size = new System.Drawing.Size(50, 15);
            this.Model_C.TabIndex = 3;
            this.Model_C.Text = "Модель";
            // 
            // Max_Speed_C
            // 
            this.Max_Speed_C.AutoSize = true;
            this.Max_Speed_C.Location = new System.Drawing.Point(12, 49);
            this.Max_Speed_C.Name = "Max_Speed_C";
            this.Max_Speed_C.Size = new System.Drawing.Size(143, 15);
            this.Max_Speed_C.TabIndex = 4;
            this.Max_Speed_C.Text = "Максимальная скорость";
            // 
            // Create_Moto
            // 
            this.Create_Moto.Location = new System.Drawing.Point(12, 127);
            this.Create_Moto.Name = "Create_Moto";
            this.Create_Moto.Size = new System.Drawing.Size(104, 23);
            this.Create_Moto.TabIndex = 6;
            this.Create_Moto.Text = "Создать";
            this.Create_Moto.UseVisualStyleBackColor = true;
            this.Create_Moto.Click += new System.EventHandler(this.Create_Moto_Click);
            // 
            // Create_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.Create_Moto);
            this.Controls.Add(this.Max_Speed_C);
            this.Controls.Add(this.Model_C);
            this.Controls.Add(this.max_speed_value);
            this.Controls.Add(this.Model_value);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 201);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 201);
            this.Name = "Create_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Создание";
            ((System.ComponentModel.ISupportInitialize)(this.max_speed_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Model_value;
        private NumericUpDown max_speed_value;
        private Label Model_C;
        private Label Max_Speed_C;
        private Button Create_Moto;
    }
}