namespace CSharpLabs.Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabTask2));
            this.condition = new System.Windows.Forms.Button();
            this.speed = new System.Windows.Forms.Button();
            this.create_motobike = new System.Windows.Forms.Button();
            this.back_to_titile = new System.Windows.Forms.Button();
            this.pictureBox_ = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_)).BeginInit();
            this.SuspendLayout();
            // 
            // condition
            // 
            this.condition.Location = new System.Drawing.Point(12, 12);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(98, 37);
            this.condition.TabIndex = 0;
            this.condition.Text = "Состояние";
            this.condition.UseVisualStyleBackColor = true;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(12, 55);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(98, 38);
            this.speed.TabIndex = 1;
            this.speed.Text = "Изменить скорость";
            this.speed.UseVisualStyleBackColor = true;
            // 
            // create_motobike
            // 
            this.create_motobike.Location = new System.Drawing.Point(12, 99);
            this.create_motobike.Name = "create_motobike";
            this.create_motobike.Size = new System.Drawing.Size(98, 38);
            this.create_motobike.TabIndex = 2;
            this.create_motobike.Text = "Создать новый";
            this.create_motobike.UseVisualStyleBackColor = true;
            // 
            // back_to_titile
            // 
            this.back_to_titile.Location = new System.Drawing.Point(12, 289);
            this.back_to_titile.Name = "back_to_titile";
            this.back_to_titile.Size = new System.Drawing.Size(98, 23);
            this.back_to_titile.TabIndex = 3;
            this.back_to_titile.Text = "Выход";
            this.back_to_titile.UseVisualStyleBackColor = true;
            // 
            // pictureBox_
            // 
            this.pictureBox_.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_.Image")));
            this.pictureBox_.Location = new System.Drawing.Point(127, 12);
            this.pictureBox_.Name = "pictureBox_";
            this.pictureBox_.Size = new System.Drawing.Size(300, 232);
            this.pictureBox_.TabIndex = 4;
            this.pictureBox_.TabStop = false;
            // 
            // LabTask2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 323);
            this.Controls.Add(this.pictureBox_);
            this.Controls.Add(this.back_to_titile);
            this.Controls.Add(this.create_motobike);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.condition);
            this.Name = "LabTask2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button condition;
        private Button speed;
        private Button create_motobike;
        private Button back_to_titile;
        private PictureBox pictureBox_;
    }
}