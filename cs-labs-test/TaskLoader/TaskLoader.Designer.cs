namespace CSharpLabs.TaskLoader
{
    partial class TaskLoader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.load_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.info_button = new System.Windows.Forms.Button();
            this.labname_label = new System.Windows.Forms.Label();
            this.labname_textbox = new System.Windows.Forms.TextBox();
            this.taskname_textbox = new System.Windows.Forms.TextBox();
            this.taskname_label = new System.Windows.Forms.Label();
            this.task_treeview = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(12, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(350, 32);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Загрузчик лабораторной работы";
            // 
            // load_button
            // 
            this.load_button.BackColor = System.Drawing.Color.White;
            this.load_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_button.Location = new System.Drawing.Point(194, 252);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(168, 30);
            this.load_button.TabIndex = 2;
            this.load_button.Text = "Загрузка";
            this.load_button.UseVisualStyleBackColor = false;
            // 
            // refresh_button
            // 
            this.refresh_button.BackColor = System.Drawing.Color.White;
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(14, 252);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(166, 30);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = false;
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.White;
            this.info_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_button.Location = new System.Drawing.Point(194, 212);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(166, 30);
            this.info_button.TabIndex = 4;
            this.info_button.Text = "Информация";
            this.info_button.UseVisualStyleBackColor = false;
            // 
            // labname_label
            // 
            this.labname_label.AutoSize = true;
            this.labname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labname_label.Location = new System.Drawing.Point(194, 52);
            this.labname_label.Name = "labname_label";
            this.labname_label.Size = new System.Drawing.Size(123, 19);
            this.labname_label.TabIndex = 5;
            this.labname_label.Text = "Название работы:";
            // 
            // labname_textbox
            // 
            this.labname_textbox.BackColor = System.Drawing.Color.White;
            this.labname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labname_textbox.Location = new System.Drawing.Point(194, 74);
            this.labname_textbox.Name = "labname_textbox";
            this.labname_textbox.ReadOnly = true;
            this.labname_textbox.Size = new System.Drawing.Size(166, 29);
            this.labname_textbox.TabIndex = 6;
            // 
            // taskname_textbox
            // 
            this.taskname_textbox.BackColor = System.Drawing.Color.White;
            this.taskname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskname_textbox.Location = new System.Drawing.Point(194, 136);
            this.taskname_textbox.Name = "taskname_textbox";
            this.taskname_textbox.ReadOnly = true;
            this.taskname_textbox.Size = new System.Drawing.Size(166, 29);
            this.taskname_textbox.TabIndex = 8;
            // 
            // taskname_label
            // 
            this.taskname_label.AutoSize = true;
            this.taskname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.taskname_label.Location = new System.Drawing.Point(194, 114);
            this.taskname_label.Name = "taskname_label";
            this.taskname_label.Size = new System.Drawing.Size(127, 19);
            this.taskname_label.TabIndex = 7;
            this.taskname_label.Text = "Название задания:";
            // 
            // task_treeview
            // 
            this.task_treeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.task_treeview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.task_treeview.Location = new System.Drawing.Point(12, 52);
            this.task_treeview.Name = "task_treeview";
            this.task_treeview.Size = new System.Drawing.Size(168, 190);
            this.task_treeview.TabIndex = 9;
            // 
            // TaskLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 294);
            this.Controls.Add(this.task_treeview);
            this.Controls.Add(this.taskname_textbox);
            this.Controls.Add(this.taskname_label);
            this.Controls.Add(this.labname_textbox);
            this.Controls.Add(this.labname_label);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.title_label);
            this.MaximumSize = new System.Drawing.Size(388, 333);
            this.MinimumSize = new System.Drawing.Size(388, 333);
            this.Name = "TaskLoader";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label title_label;
        private Button load_button;
        private Button refresh_button;
        private Button info_button;
        private Label labname_label;
        private TextBox labname_textbox;
        private TextBox taskname_textbox;
        private Label taskname_label;
        private TreeView task_treeview;
    }
}