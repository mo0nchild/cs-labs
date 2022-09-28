namespace CSharpLabs.LabsLoader
{
    partial class LabsSelecter
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
            this.load_button = new System.Windows.Forms.Button();
            this.refresh_button = new System.Windows.Forms.Button();
            this.labs_listview = new System.Windows.Forms.ListView();
            this.assembly_columnheader = new System.Windows.Forms.ColumnHeader();
            this.name_columnheader = new System.Windows.Forms.ColumnHeader();
            this.labname_columnheader = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(17, 9);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(377, 27);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Выбор лабораторной работы для запуска\r\n";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.load_button.Location = new System.Drawing.Point(18, 198);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(183, 31);
            this.load_button.TabIndex = 3;
            this.load_button.Text = "Загрузить";
            this.load_button.UseVisualStyleBackColor = true;
            // 
            // refresh_button
            // 
            this.refresh_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refresh_button.Location = new System.Drawing.Point(211, 198);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(183, 31);
            this.refresh_button.TabIndex = 4;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            // 
            // labs_listview
            // 
            this.labs_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.assembly_columnheader,
            this.name_columnheader,
            this.labname_columnheader});
            this.labs_listview.FullRowSelect = true;
            this.labs_listview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.labs_listview.Location = new System.Drawing.Point(17, 48);
            this.labs_listview.MultiSelect = false;
            this.labs_listview.Name = "labs_listview";
            this.labs_listview.Size = new System.Drawing.Size(377, 144);
            this.labs_listview.TabIndex = 5;
            this.labs_listview.UseCompatibleStateImageBehavior = false;
            this.labs_listview.View = System.Windows.Forms.View.Details;
            // 
            // assembly_columnheader
            // 
            this.assembly_columnheader.Text = "Сборка";
            this.assembly_columnheader.Width = 100;
            // 
            // name_columnheader
            // 
            this.name_columnheader.Text = "Имя класса";
            this.name_columnheader.Width = 160;
            // 
            // labname_columnheader
            // 
            this.labname_columnheader.Text = "Название работы";
            this.labname_columnheader.Width = 120;
            // 
            // LabsSelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 243);
            this.Controls.Add(this.labs_listview);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.title_label);
            this.Name = "LabsSelecter";
            this.Text = "Загрузчик";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title_label;
        private Button load_button;
        private Button refresh_button;
        private ListView labs_listview;
        private ColumnHeader assembly_columnheader;
        private ColumnHeader name_columnheader;
        private ColumnHeader labname_columnheader;
    }
}