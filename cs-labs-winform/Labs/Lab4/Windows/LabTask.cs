using CSharpLabs.Supports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpLabs.Lab4.Logics;
using CSharpLabs.LabsLoader;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Security.Policy;
using System.Reflection;

namespace CSharpLabs.Lab4.Windows
{
    [TaskDetectAttribute("Задание 2", "WinformLab4")]
    public partial class LabTask : Form, ITaskLaunchable
    {
        private struct ObjectProperty
        {
            public string Name { get; set; }
            public object Value { get; set; }
            public Type Type { get; set; }

            public override string ToString() => $"Name: {Name}, Value: {Value}, Type: {Type}";
        }

        private List<ObjectProperty[]> object_records = new();
        private ObjectProperty[] current_record = new ObjectProperty[0];
        private object? current_object = null;

        public string TaskInfo => "Программа для ввода/вывода данных в массив с различной длинной " +
            "записей, то есть массив массивов, перечисляющий различные свойства трех различных объектов " +
            "в соответствии с таблицей вариантов.";

        public void TaskLaunch() => this.ShowDialog();

        public LabTask()
        {
            this.InitializeComponent();

            this.objecttype_combobox.SelectedIndex = default(int);
            this.valuetype_combobox.SelectedIndex = default(int);

            this.valueset_button.Click += new EventHandler(ValueSet_button_Click);
            this.add_button.Click += new EventHandler(Add_button_Click);

            this.invokemethod_button.Click += new EventHandler(Invokemethod_button_Click);
            this.useobject_button.Click += new EventHandler(Useobject_button_Click);
            this.objectstate_button.Click += new EventHandler(Objectstate_button_Click);
        }

        private void Objectstate_button_Click(object? sender, EventArgs e)
        {
            if (this.objects_listview.SelectedItems.Count == 0) return;

            this.objectstate_listview.Items.Clear();
            Type ? selected_record = null;
            foreach (var record in this.object_records)
            {
                if (this.objects_listview.SelectedItems[0].Text == record[0].Name)
                {
                    selected_record = (record[0].Value as Type)!;
                    var selecter_object = Activator.CreateInstance(selected_record);

                    if (selecter_object == null) continue;
                    foreach (var property in selected_record.GetProperties()) 
                    {
                        var row = new ListViewItem(new string[] { 
                            property.Name, 
                            property.PropertyType.ToString(),
                            property.GetValue(selecter_object)!.ToString()!
                        });
                        this.objectstate_listview.Items.Add(row);
                    }
                }
            }
        }

        private void ValueSet_button_Click(object? sender, EventArgs e)
        {
            if (this.valuename_textbox.Text == string.Empty) return;

            object? value = default;
            System.Type? valuetype = default;

            foreach(var item in this.values_listview.Items)
            {
                var row = item as ListViewItem;
                if (row!.SubItems[1].Text == this.valuename_textbox.Text) 
                {
                    MessageBox.Show("Ключ уже используется", "Ошибка");
                    return;
                }
            }
            try
            {
                switch (this.valuetype_combobox.SelectedIndex)
                {
                    case 0: (valuetype, value) = (Type.GetType("System.Int32")!, int.Parse(this.value_textbox.Text)); break;
                    case 1: (valuetype, value) = (Type.GetType("System.Double")!, double.Parse(this.value_textbox.Text)); break;
                    case 2: (valuetype, value) = (Type.GetType("System.String")!, string.Format(this.value_textbox.Text)); break;
                    case 3:
                        valuetype = Type.GetType("CSharpLabs.Lab4.Logics.Motobike+MotoType")!;
                        if (Enum.GetValues<Motobike.MotoType>().Cast<int>().Max() < int.Parse(this.value_textbox.Text)) 
                        {
                            throw new Exception("Enum value not correct");
                        }
                        value = Enum.Parse(typeof(Motobike.MotoType), this.value_textbox.Text);
                        break;
                    case 4:
                        valuetype = Type.GetType("CSharpLabs.Lab4.Logics.Airplane+AirplaneType")!;
                        if (Enum.GetValues<Airplane.AirplaneType>().Cast<int>().Max() < int.Parse(this.value_textbox.Text))
                        {
                            throw new Exception("Enum value not correct");
                        }
                        value = Enum.Parse(typeof(Airplane.AirplaneType), this.value_textbox.Text);
                        break;
                }
            }
            catch (Exception error) { MessageBox.Show(error.Message, "Ошибка"); return; }

            var buffer_record = this.current_record;
            this.current_record = new ObjectProperty[buffer_record.Length + 1];

            if (this.current_record.Length > 0)
            {
                for (int i = 0; i < buffer_record.Length; i++) this.current_record[i] = buffer_record[i];
            }

            this.current_record[this.current_record.Length - 1] = new() 
            {
                Name = this.valuename_textbox.Text,
                Type = valuetype!,
                Value = value!
            };

            var listview_record = new ListViewItem(this.valuetype_combobox.Text);
            listview_record.SubItems.Add(this.valuename_textbox.Text);
            listview_record.SubItems.Add(this.value_textbox.Text);

            this.values_listview.Items.Add(listview_record);
        }

        private void Add_button_Click(object? sender, EventArgs e)
        {
            if (this.objectname_textbox.Text == string.Empty) return;

            Type? objecttype = default;
            switch (this.objecttype_combobox.SelectedIndex) 
            {
                case 0: objecttype = Type.GetType("CSharpLabs.Lab4.Logics.Student"); break;
                case 1: objecttype = Type.GetType("CSharpLabs.Lab4.Logics.Motobike"); break;
                case 2: objecttype = Type.GetType("CSharpLabs.Lab4.Logics.Airplane"); break;
            }
            var buffer_record = new ObjectProperty[this.current_record.Length + 1];
            this.current_record.CopyTo(buffer_record, 1);
            this.current_record = new ObjectProperty[0];

            buffer_record[0] = new ObjectProperty 
            { 
                Name = this.objectname_textbox.Text,
                Type = typeof(Type),
                Value = objecttype!
            };
            this.object_records.Add(buffer_record);
            this.objects_listview.Items.Add(
                new ListViewItem(new string[] { this.objectname_textbox.Text, objecttype!.Name })
            );
            this.ResetInputElements();
        }

        private void Useobject_button_Click(object? sender, EventArgs e)
        {
            if (this.objects_listview.SelectedItems.Count == 0) return;

            Type? selected_record = null;
            foreach (var record in this.object_records)
            {
                if (this.objects_listview.SelectedItems[0].Text == record[0].Name) 
                {
                    selected_record = (record[0].Value as Type)!;
                    this.current_object = Activator.CreateInstance(selected_record);

                    if (this.current_object == null) continue;
                    foreach (var property in record)
                    {
                        var property_info = selected_record.GetProperty(property.Name);
                        if (property_info == null) continue;

                        try { property_info.SetValue(this.current_object, property.Value); }
                        catch { MessageBox.Show($"Проблема c свойством: {property.Name}", "Ошибка"); }
                    }
                }
            }
            if (selected_record == null) return;

            this.methods_listview.Items.Clear();
            this.result_textbox.Text = string.Empty;

            foreach (var method in selected_record.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where((MethodInfo info)=> !info.IsSpecialName && info.GetParameters().Length <= 1))
            {
                var methods_view = new ListViewItem(new string[] { method.Name, method.ReturnType.ToString() });
                this.methods_listview.Items.Add(methods_view);
            }
        }

        private void Invokemethod_button_Click(object? sender, EventArgs e)
        {
            if (this.methods_listview.SelectedItems.Count == 0 || this.current_object == null) return;

            var selected_method_name = this.methods_listview.SelectedItems[0].Text;
            var selected_method = this.current_object?.GetType().GetMethod(selected_method_name);

            object? result = default;
            try 
            {
                try { result = selected_method?.Invoke(this.current_object, new object[] { }); }
                catch 
                {
                    object inputvalue = new();
                    switch (this.inputtype_combobox.SelectedIndex) 
                    {
                        case 0: inputvalue = int.Parse(this.input_textbox.Text); break;
                        case 1: inputvalue = double.Parse(this.input_textbox.Text); break;
                        case 2: inputvalue = this.input_textbox.Text; break;
                    }
                    result = selected_method?.Invoke(this.current_object, new object[] { inputvalue });
                }
                this.result_textbox.Text = (selected_method?.ReturnType == typeof(void)) 
                    ? "Фукнция выполнена" : result!.ToString();
            }
            catch { this.result_textbox.Text = "Ошибка выполнения функции"; }
        }

        private void ResetInputElements() 
        {
            this.objecttype_combobox.SelectedIndex = default(int);
            this.valuetype_combobox.SelectedIndex = default(int);

            this.valuename_textbox.Text = string.Empty;
            this.objectname_textbox.Text = string.Empty;
            this.value_textbox.Text = string.Empty;
            
            this.values_listview.Items.Clear();
        }
    }
}
