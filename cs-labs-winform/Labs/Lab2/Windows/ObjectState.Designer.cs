namespace CSharpLabs.Lab2.Windows
{
    partial class Condition_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.model_v = new System.Windows.Forms.Label();
            this.speed_v = new System.Windows.Forms.Label();
            this.max_speed_v = new System.Windows.Forms.Label();
            this.serial_number_v = new System.Windows.Forms.Label();
            this.model_value = new System.Windows.Forms.Label();
            this.speed_value = new System.Windows.Forms.Label();
            this.max_speed_value = new System.Windows.Forms.Label();
            this.serial_number_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 167);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // model_v
            // 
            this.model_v.AutoSize = true;
            this.model_v.Location = new System.Drawing.Point(12, 12);
            this.model_v.Name = "model_v";
            this.model_v.Size = new System.Drawing.Size(53, 15);
            this.model_v.TabIndex = 1;
            this.model_v.Text = "Модель:";
            // 
            // speed_v
            // 
            this.speed_v.AutoSize = true;
            this.speed_v.Location = new System.Drawing.Point(12, 27);
            this.speed_v.Name = "speed_v";
            this.speed_v.Size = new System.Drawing.Size(62, 15);
            this.speed_v.TabIndex = 2;
            this.speed_v.Text = "Скорость:";
            // 
            // max_speed_v
            // 
            this.max_speed_v.AutoSize = true;
            this.max_speed_v.Location = new System.Drawing.Point(12, 42);
            this.max_speed_v.Name = "max_speed_v";
            this.max_speed_v.Size = new System.Drawing.Size(146, 15);
            this.max_speed_v.TabIndex = 3;
            this.max_speed_v.Text = "Максимальная скорость:";
            // 
            // serial_number_v
            // 
            this.serial_number_v.AutoSize = true;
            this.serial_number_v.Location = new System.Drawing.Point(12, 73);
            this.serial_number_v.Name = "serial_number_v";
            this.serial_number_v.Size = new System.Drawing.Size(107, 15);
            this.serial_number_v.TabIndex = 4;
            this.serial_number_v.Text = "Серийный номер:";
            // 
            // model_value
            // 
            this.model_value.AutoSize = true;
            this.model_value.Location = new System.Drawing.Point(169, 12);
            this.model_value.Name = "model_value";
            this.model_value.Size = new System.Drawing.Size(85, 15);
            this.model_value.TabIndex = 5;
            this.model_value.Text = "Классический";
            // 
            // speed_value
            // 
            this.speed_value.AutoSize = true;
            this.speed_value.Location = new System.Drawing.Point(169, 27);
            this.speed_value.Name = "speed_value";
            this.speed_value.Size = new System.Drawing.Size(13, 15);
            this.speed_value.TabIndex = 6;
            this.speed_value.Text = "0";
            // 
            // max_speed_value
            // 
            this.max_speed_value.AutoSize = true;
            this.max_speed_value.Location = new System.Drawing.Point(169, 42);
            this.max_speed_value.Name = "max_speed_value";
            this.max_speed_value.Size = new System.Drawing.Size(34, 15);
            this.max_speed_value.TabIndex = 7;
            this.max_speed_value.Text = "101.0";
            // 
            // serial_number_value
            // 
            this.serial_number_value.AutoSize = true;
            this.serial_number_value.Location = new System.Drawing.Point(169, 73);
            this.serial_number_value.Name = "serial_number_value";
            this.serial_number_value.Size = new System.Drawing.Size(13, 15);
            this.serial_number_value.TabIndex = 8;
            this.serial_number_value.Text = "0";
            // 
            // Condition_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 271);
            this.Controls.Add(this.serial_number_value);
            this.Controls.Add(this.max_speed_value);
            this.Controls.Add(this.speed_value);
            this.Controls.Add(this.model_value);
            this.Controls.Add(this.serial_number_v);
            this.Controls.Add(this.max_speed_v);
            this.Controls.Add(this.speed_v);
            this.Controls.Add(this.model_v);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(281, 310);
            this.Name = "Condition_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Состояние";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label model_v;
        private Label speed_v;
        private Label max_speed_v;
        private Label serial_number_v;
        private Label model_value;
        private Label speed_value;
        private Label max_speed_value;
        private Label serial_number_value;
    }
}