using CSharpLabs.Supports;

namespace CSharpLabs.Lab3.Windows
{
    public partial class MainMenu : Form, ILabRunner
    {
        public string LabName => "WinformLab3";

        public MainMenu()
        {
            this.InitializeComponent();
            this.task_combobox.SelectedIndex = default(int);

            this.exit_button.Click += new EventHandler(ExitButton_Click);
            this.help_button.Click += new EventHandler(HelpButton_Click);

            this.info_button.Click += new EventHandler(InfoButton_Click);
            this.start_button.Click += new EventHandler(StartButton_Click);
        }

        public void RunLab() => this.ShowDialog();

        private void StartButton_Click(object? sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex)
            {
                case 0: new LabTask5().ShowDialog(); break;
                default: break;
            }
        }

        private void HelpButton_Click(object? sender, EventArgs e)
        {
            string taskinfo_message = string.Empty;
            switch (this.task_combobox.SelectedIndex)
            {
                case 0: taskinfo_message = "Найти сумму бесконечного ряда. Суммировать пока члены ряда не станут меньше заданного eps > 0."; break;
                case 1: taskinfo_message = "Вычисление значений заданной функции в каждой точке отрезка и найти сумму полученных значений."; break;
                case 2: taskinfo_message = "Дано целое число N, выбросить из его записи цифры 0 и 5, сохранив прежний порядок остальных цифр."; break;
                case 3: taskinfo_message = "Дано целое число N (N > 0), используя один цикл, найти сумму 1! +2! + 3! +...+N!"; break;
            }
            MessageBox.Show(taskinfo_message, "Информация задания");
        }

        private void InfoButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Цель лабораторной работы: изучение основ программирования циклов на языке C#" +
                "и получение навыков работы с циклами в визуальном приложении на платформе .NET Framework.", 
                "Краткие сведения");
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}