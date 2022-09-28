using CSharpLabs.Supports;
using System.Reflection;

namespace CSharpLabs.LabsLoader
{
    public partial class MainMenu : Form
    {
        public TaskLoader task_loader;

        public MainMenu(TaskLoader task_loader)
        {
            this.task_loader = task_loader;

            this.InitializeComponent();
            this.TasksListSetup();

            this.main_label.Text = $"Лабораторная работа №{this.task_loader.LabNumber}";

            this.exit_button.Click += new EventHandler(ExitButton_Click);
            this.help_button.Click += new EventHandler(HelpButton_Click);

            this.info_button.Click += new EventHandler(InfoButton_Click);
            this.start_button.Click += new EventHandler(StartButton_Click);
        }

        private void TasksListSetup() 
        {
            this.task_combobox.Items.Clear();
            foreach (var item in this.task_loader) this.task_combobox.Items.Add(item);

            if (this.task_combobox.Items.Count > 0) this.task_combobox.SelectedIndex = default(int);
        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
            if(this.task_combobox.SelectedIndex >= 0) task_loader.LaunchTask(this.task_combobox.SelectedItem.ToString()!);
        }

        private void HelpButton_Click(object? sender, EventArgs e)
        {
            if (this.task_combobox.SelectedIndex >= 0)
            {
                var msg = task_loader.GetTaskInfo(this.task_combobox.SelectedItem.ToString()!);
                MessageBox.Show(msg, "Информация по заданию");
            }
        }

        private void InfoButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show($"Название лабораторной работы: {this.task_loader.LabName}", "Краткие сведения");
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}