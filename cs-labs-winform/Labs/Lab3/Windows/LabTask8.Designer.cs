﻿namespace CSharpLabs.Lab3.Windows
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
            // LabTask8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 335);
            this.Controls.Add(this.task1_title_label);
            this.MaximumSize = new System.Drawing.Size(434, 374);
            this.MinimumSize = new System.Drawing.Size(434, 374);
            this.Name = "LabTask8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label task1_title_label;
    }
}