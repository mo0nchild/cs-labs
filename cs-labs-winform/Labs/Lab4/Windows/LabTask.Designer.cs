namespace CSharpLabs.Lab4.Windows
{
    partial class LabTask
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
            this.task_tabcontrol = new System.Windows.Forms.TabControl();
            this.create_tabpage = new System.Windows.Forms.TabPage();
            this.valuetype_combobox = new System.Windows.Forms.ComboBox();
            this.values_listview = new System.Windows.Forms.ListView();
            this.valuetype = new System.Windows.Forms.ColumnHeader();
            this.valuename = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.add_button = new System.Windows.Forms.Button();
            this.value_label = new System.Windows.Forms.Label();
            this.value_textbox = new System.Windows.Forms.TextBox();
            this.valuename_label = new System.Windows.Forms.Label();
            this.valuename_textbox = new System.Windows.Forms.TextBox();
            this.valuetype_label = new System.Windows.Forms.Label();
            this.objecttype_combobox = new System.Windows.Forms.ComboBox();
            this.objecttype_label = new System.Windows.Forms.Label();
            this.objectname_label = new System.Windows.Forms.Label();
            this.objectname_textbox = new System.Windows.Forms.TextBox();
            this.valueset_button = new System.Windows.Forms.Button();
            this.use_tabpage = new System.Windows.Forms.TabPage();
            this.inputtype_combobox = new System.Windows.Forms.ComboBox();
            this.inputtype_label = new System.Windows.Forms.Label();
            this.input_label = new System.Windows.Forms.Label();
            this.input_textbox = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.TextBox();
            this.invokemethod_button = new System.Windows.Forms.Button();
            this.useobject_button = new System.Windows.Forms.Button();
            this.methods_label = new System.Windows.Forms.Label();
            this.methods_listview = new System.Windows.Forms.ListView();
            this.method_name = new System.Windows.Forms.ColumnHeader();
            this.method_returntype = new System.Windows.Forms.ColumnHeader();
            this.state_tabpage = new System.Windows.Forms.TabPage();
            this.objects_listview = new System.Windows.Forms.ListView();
            this.objectname = new System.Windows.Forms.ColumnHeader();
            this.objecttype = new System.Windows.Forms.ColumnHeader();
            this.list_label = new System.Windows.Forms.Label();
            this.objectstate_listview = new System.Windows.Forms.ListView();
            this.propertyname = new System.Windows.Forms.ColumnHeader();
            this.propertyvalue = new System.Windows.Forms.ColumnHeader();
            this.objectstate_button = new System.Windows.Forms.Button();
            this.propertytype = new System.Windows.Forms.ColumnHeader();
            this.task_tabcontrol.SuspendLayout();
            this.create_tabpage.SuspendLayout();
            this.use_tabpage.SuspendLayout();
            this.state_tabpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // task_tabcontrol
            // 
            this.task_tabcontrol.Controls.Add(this.create_tabpage);
            this.task_tabcontrol.Controls.Add(this.use_tabpage);
            this.task_tabcontrol.Controls.Add(this.state_tabpage);
            this.task_tabcontrol.Location = new System.Drawing.Point(12, 12);
            this.task_tabcontrol.Name = "task_tabcontrol";
            this.task_tabcontrol.SelectedIndex = 0;
            this.task_tabcontrol.Size = new System.Drawing.Size(324, 392);
            this.task_tabcontrol.TabIndex = 0;
            // 
            // create_tabpage
            // 
            this.create_tabpage.Controls.Add(this.valuetype_combobox);
            this.create_tabpage.Controls.Add(this.values_listview);
            this.create_tabpage.Controls.Add(this.add_button);
            this.create_tabpage.Controls.Add(this.value_label);
            this.create_tabpage.Controls.Add(this.value_textbox);
            this.create_tabpage.Controls.Add(this.valuename_label);
            this.create_tabpage.Controls.Add(this.valuename_textbox);
            this.create_tabpage.Controls.Add(this.valuetype_label);
            this.create_tabpage.Controls.Add(this.objecttype_combobox);
            this.create_tabpage.Controls.Add(this.objecttype_label);
            this.create_tabpage.Controls.Add(this.objectname_label);
            this.create_tabpage.Controls.Add(this.objectname_textbox);
            this.create_tabpage.Controls.Add(this.valueset_button);
            this.create_tabpage.Location = new System.Drawing.Point(4, 24);
            this.create_tabpage.Name = "create_tabpage";
            this.create_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.create_tabpage.Size = new System.Drawing.Size(316, 364);
            this.create_tabpage.TabIndex = 0;
            this.create_tabpage.Text = "Создание";
            this.create_tabpage.UseVisualStyleBackColor = true;
            // 
            // valuetype_combobox
            // 
            this.valuetype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valuetype_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuetype_combobox.FormattingEnabled = true;
            this.valuetype_combobox.Items.AddRange(new object[] {
            "Int32",
            "Double",
            "String",
            "MotobikeType",
            "AirplaneType"});
            this.valuetype_combobox.Location = new System.Drawing.Point(161, 82);
            this.valuetype_combobox.Name = "valuetype_combobox";
            this.valuetype_combobox.Size = new System.Drawing.Size(145, 29);
            this.valuetype_combobox.TabIndex = 17;
            // 
            // values_listview
            // 
            this.values_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.valuetype,
            this.valuename,
            this.value});
            this.values_listview.Location = new System.Drawing.Point(6, 176);
            this.values_listview.Name = "values_listview";
            this.values_listview.Size = new System.Drawing.Size(301, 130);
            this.values_listview.TabIndex = 11;
            this.values_listview.UseCompatibleStateImageBehavior = false;
            this.values_listview.View = System.Windows.Forms.View.Details;
            // 
            // valuetype
            // 
            this.valuetype.Text = "Тип";
            this.valuetype.Width = 80;
            // 
            // valuename
            // 
            this.valuename.Text = "Название";
            this.valuename.Width = 80;
            // 
            // value
            // 
            this.value.Text = "Значение";
            this.value.Width = 120;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(161, 317);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(145, 32);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "Добавить объект";
            this.add_button.UseVisualStyleBackColor = true;
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_label.Location = new System.Drawing.Point(6, 114);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(73, 19);
            this.value_label.TabIndex = 15;
            this.value_label.Text = "Значение:";
            // 
            // value_textbox
            // 
            this.value_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.value_textbox.Location = new System.Drawing.Point(6, 136);
            this.value_textbox.MaxLength = 40;
            this.value_textbox.Name = "value_textbox";
            this.value_textbox.Size = new System.Drawing.Size(300, 29);
            this.value_textbox.TabIndex = 14;
            // 
            // valuename_label
            // 
            this.valuename_label.AutoSize = true;
            this.valuename_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuename_label.Location = new System.Drawing.Point(6, 60);
            this.valuename_label.Name = "valuename_label";
            this.valuename_label.Size = new System.Drawing.Size(98, 19);
            this.valuename_label.TabIndex = 13;
            this.valuename_label.Text = "Имя свойства:";
            // 
            // valuename_textbox
            // 
            this.valuename_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valuename_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuename_textbox.Location = new System.Drawing.Point(6, 82);
            this.valuename_textbox.MaxLength = 20;
            this.valuename_textbox.Name = "valuename_textbox";
            this.valuename_textbox.Size = new System.Drawing.Size(145, 29);
            this.valuename_textbox.TabIndex = 12;
            // 
            // valuetype_label
            // 
            this.valuetype_label.AutoSize = true;
            this.valuetype_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valuetype_label.Location = new System.Drawing.Point(161, 60);
            this.valuetype_label.Name = "valuetype_label";
            this.valuetype_label.Size = new System.Drawing.Size(98, 19);
            this.valuetype_label.TabIndex = 11;
            this.valuetype_label.Text = "Тип значения:";
            // 
            // objecttype_combobox
            // 
            this.objecttype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objecttype_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objecttype_combobox.FormattingEnabled = true;
            this.objecttype_combobox.Items.AddRange(new object[] {
            "Студент",
            "Мотоцикл",
            "Самолет"});
            this.objecttype_combobox.Location = new System.Drawing.Point(161, 28);
            this.objecttype_combobox.Name = "objecttype_combobox";
            this.objecttype_combobox.Size = new System.Drawing.Size(145, 29);
            this.objecttype_combobox.TabIndex = 9;
            // 
            // objecttype_label
            // 
            this.objecttype_label.AutoSize = true;
            this.objecttype_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objecttype_label.Location = new System.Drawing.Point(161, 6);
            this.objecttype_label.Name = "objecttype_label";
            this.objecttype_label.Size = new System.Drawing.Size(90, 19);
            this.objecttype_label.TabIndex = 8;
            this.objecttype_label.Text = "Тип объекта:";
            // 
            // objectname_label
            // 
            this.objectname_label.AutoSize = true;
            this.objectname_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectname_label.Location = new System.Drawing.Point(6, 6);
            this.objectname_label.Name = "objectname_label";
            this.objectname_label.Size = new System.Drawing.Size(94, 19);
            this.objectname_label.TabIndex = 6;
            this.objectname_label.Text = "Имя объекта:";
            // 
            // objectname_textbox
            // 
            this.objectname_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectname_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectname_textbox.Location = new System.Drawing.Point(6, 28);
            this.objectname_textbox.MaxLength = 20;
            this.objectname_textbox.Name = "objectname_textbox";
            this.objectname_textbox.Size = new System.Drawing.Size(145, 29);
            this.objectname_textbox.TabIndex = 5;
            // 
            // valueset_button
            // 
            this.valueset_button.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueset_button.Location = new System.Drawing.Point(6, 317);
            this.valueset_button.Name = "valueset_button";
            this.valueset_button.Size = new System.Drawing.Size(149, 32);
            this.valueset_button.TabIndex = 4;
            this.valueset_button.Text = "Добавить значение";
            this.valueset_button.UseVisualStyleBackColor = true;
            // 
            // use_tabpage
            // 
            this.use_tabpage.Controls.Add(this.inputtype_combobox);
            this.use_tabpage.Controls.Add(this.inputtype_label);
            this.use_tabpage.Controls.Add(this.input_label);
            this.use_tabpage.Controls.Add(this.input_textbox);
            this.use_tabpage.Controls.Add(this.result_label);
            this.use_tabpage.Controls.Add(this.result_textbox);
            this.use_tabpage.Controls.Add(this.invokemethod_button);
            this.use_tabpage.Controls.Add(this.useobject_button);
            this.use_tabpage.Controls.Add(this.methods_label);
            this.use_tabpage.Controls.Add(this.methods_listview);
            this.use_tabpage.Location = new System.Drawing.Point(4, 24);
            this.use_tabpage.Name = "use_tabpage";
            this.use_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.use_tabpage.Size = new System.Drawing.Size(316, 364);
            this.use_tabpage.TabIndex = 1;
            this.use_tabpage.Text = "Использование";
            this.use_tabpage.UseVisualStyleBackColor = true;
            // 
            // inputtype_combobox
            // 
            this.inputtype_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputtype_combobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputtype_combobox.FormattingEnabled = true;
            this.inputtype_combobox.Items.AddRange(new object[] {
            "Int32",
            "Double",
            "String"});
            this.inputtype_combobox.Location = new System.Drawing.Point(165, 199);
            this.inputtype_combobox.Name = "inputtype_combobox";
            this.inputtype_combobox.Size = new System.Drawing.Size(145, 29);
            this.inputtype_combobox.TabIndex = 19;
            // 
            // inputtype_label
            // 
            this.inputtype_label.AutoSize = true;
            this.inputtype_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputtype_label.Location = new System.Drawing.Point(160, 177);
            this.inputtype_label.Name = "inputtype_label";
            this.inputtype_label.Size = new System.Drawing.Size(98, 19);
            this.inputtype_label.TabIndex = 18;
            this.inputtype_label.Text = "Тип значения:";
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_label.Location = new System.Drawing.Point(6, 177);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(128, 19);
            this.input_label.TabIndex = 17;
            this.input_label.Text = "Входное значение:";
            // 
            // input_textbox
            // 
            this.input_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_textbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_textbox.Location = new System.Drawing.Point(6, 199);
            this.input_textbox.MaxLength = 20;
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(150, 29);
            this.input_textbox.TabIndex = 16;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.Location = new System.Drawing.Point(6, 231);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(126, 19);
            this.result_label.TabIndex = 15;
            this.result_label.Text = "Результат вызова: ";
            // 
            // result_textbox
            // 
            this.result_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_textbox.Location = new System.Drawing.Point(6, 253);
            this.result_textbox.Multiline = true;
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.ReadOnly = true;
            this.result_textbox.Size = new System.Drawing.Size(304, 53);
            this.result_textbox.TabIndex = 14;
            // 
            // invokemethod_button
            // 
            this.invokemethod_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.invokemethod_button.Location = new System.Drawing.Point(4, 316);
            this.invokemethod_button.Name = "invokemethod_button";
            this.invokemethod_button.Size = new System.Drawing.Size(304, 32);
            this.invokemethod_button.TabIndex = 13;
            this.invokemethod_button.Text = "Вызвать функцию";
            this.invokemethod_button.UseVisualStyleBackColor = true;
            // 
            // useobject_button
            // 
            this.useobject_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.useobject_button.Location = new System.Drawing.Point(6, 142);
            this.useobject_button.Name = "useobject_button";
            this.useobject_button.Size = new System.Drawing.Size(304, 32);
            this.useobject_button.TabIndex = 12;
            this.useobject_button.Text = "Использовать объект";
            this.useobject_button.UseVisualStyleBackColor = true;
            // 
            // methods_label
            // 
            this.methods_label.AutoSize = true;
            this.methods_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methods_label.Location = new System.Drawing.Point(6, 12);
            this.methods_label.Name = "methods_label";
            this.methods_label.Size = new System.Drawing.Size(193, 19);
            this.methods_label.TabIndex = 11;
            this.methods_label.Text = "Список доступных функций: ";
            // 
            // methods_listview
            // 
            this.methods_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.method_name,
            this.method_returntype});
            this.methods_listview.FullRowSelect = true;
            this.methods_listview.Location = new System.Drawing.Point(6, 34);
            this.methods_listview.MultiSelect = false;
            this.methods_listview.Name = "methods_listview";
            this.methods_listview.Size = new System.Drawing.Size(304, 102);
            this.methods_listview.TabIndex = 0;
            this.methods_listview.UseCompatibleStateImageBehavior = false;
            this.methods_listview.View = System.Windows.Forms.View.Details;
            // 
            // method_name
            // 
            this.method_name.Text = "Название функции";
            this.method_name.Width = 200;
            // 
            // method_returntype
            // 
            this.method_returntype.Text = "Тип";
            this.method_returntype.Width = 100;
            // 
            // state_tabpage
            // 
            this.state_tabpage.Controls.Add(this.objectstate_button);
            this.state_tabpage.Controls.Add(this.objectstate_listview);
            this.state_tabpage.Location = new System.Drawing.Point(4, 24);
            this.state_tabpage.Name = "state_tabpage";
            this.state_tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.state_tabpage.Size = new System.Drawing.Size(316, 364);
            this.state_tabpage.TabIndex = 2;
            this.state_tabpage.Text = "Состояние";
            this.state_tabpage.UseVisualStyleBackColor = true;
            // 
            // objects_listview
            // 
            this.objects_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objects_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.objectname,
            this.objecttype});
            this.objects_listview.FullRowSelect = true;
            this.objects_listview.Location = new System.Drawing.Point(342, 36);
            this.objects_listview.MultiSelect = false;
            this.objects_listview.Name = "objects_listview";
            this.objects_listview.Size = new System.Drawing.Size(298, 364);
            this.objects_listview.TabIndex = 2;
            this.objects_listview.UseCompatibleStateImageBehavior = false;
            this.objects_listview.View = System.Windows.Forms.View.Details;
            // 
            // objectname
            // 
            this.objectname.Text = "Название";
            this.objectname.Width = 150;
            // 
            // objecttype
            // 
            this.objecttype.Text = "Тип объекта";
            this.objecttype.Width = 150;
            // 
            // list_label
            // 
            this.list_label.AutoSize = true;
            this.list_label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_label.Location = new System.Drawing.Point(342, 9);
            this.list_label.Name = "list_label";
            this.list_label.Size = new System.Drawing.Size(196, 19);
            this.list_label.TabIndex = 10;
            this.list_label.Text = "Список доступных объектов: ";
            // 
            // objectstate_listview
            // 
            this.objectstate_listview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectstate_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.propertyname,
            this.propertytype,
            this.propertyvalue});
            this.objectstate_listview.FullRowSelect = true;
            this.objectstate_listview.Location = new System.Drawing.Point(9, 8);
            this.objectstate_listview.MultiSelect = false;
            this.objectstate_listview.Name = "objectstate_listview";
            this.objectstate_listview.Size = new System.Drawing.Size(298, 299);
            this.objectstate_listview.TabIndex = 11;
            this.objectstate_listview.UseCompatibleStateImageBehavior = false;
            this.objectstate_listview.View = System.Windows.Forms.View.Details;
            // 
            // propertyname
            // 
            this.propertyname.Text = "Название";
            this.propertyname.Width = 100;
            // 
            // propertyvalue
            // 
            this.propertyvalue.Text = "Значение";
            this.propertyvalue.Width = 100;
            // 
            // objectstate_button
            // 
            this.objectstate_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.objectstate_button.Location = new System.Drawing.Point(9, 319);
            this.objectstate_button.Name = "objectstate_button";
            this.objectstate_button.Size = new System.Drawing.Size(298, 32);
            this.objectstate_button.TabIndex = 13;
            this.objectstate_button.Text = "Показать состояние";
            this.objectstate_button.UseVisualStyleBackColor = true;
            // 
            // propertytype
            // 
            this.propertytype.Text = "Тип";
            this.propertytype.Width = 100;
            // 
            // LabTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 416);
            this.Controls.Add(this.list_label);
            this.Controls.Add(this.objects_listview);
            this.Controls.Add(this.task_tabcontrol);
            this.MaximumSize = new System.Drawing.Size(664, 455);
            this.MinimumSize = new System.Drawing.Size(664, 455);
            this.Name = "LabTask";
            this.Text = "Задание 2";
            this.task_tabcontrol.ResumeLayout(false);
            this.create_tabpage.ResumeLayout(false);
            this.create_tabpage.PerformLayout();
            this.use_tabpage.ResumeLayout(false);
            this.use_tabpage.PerformLayout();
            this.state_tabpage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl task_tabcontrol;
        private TabPage create_tabpage;
        private ComboBox objecttype_combobox;
        private Label objecttype_label;
        private Label objectname_label;
        private TextBox objectname_textbox;
        private Button valueset_button;
        private TabPage use_tabpage;
        private Label result_label;
        private TextBox result_textbox;
        private Button invokemethod_button;
        private Button useobject_button;
        private Label methods_label;
        private ListView methods_listview;
        private ColumnHeader method_returntype;
        private ColumnHeader method_name;
        private ListView objects_listview;
        private ColumnHeader objectname;
        private ColumnHeader objecttype;
        private Label list_label;
        private ListView values_listview;
        private ColumnHeader valuetype;
        private ColumnHeader valuename;
        private Button add_button;
        private Label value_label;
        private TextBox value_textbox;
        private Label valuename_label;
        private TextBox valuename_textbox;
        private Label valuetype_label;
        private ComboBox valuetype_combobox;
        private ColumnHeader value;
        private TabPage state_tabpage;
        private Label input_label;
        private TextBox input_textbox;
        private ComboBox inputtype_combobox;
        private Label inputtype_label;
        private Button objectstate_button;
        private ListView objectstate_listview;
        private ColumnHeader propertyname;
        private ColumnHeader propertytype;
        private ColumnHeader propertyvalue;
    }
}