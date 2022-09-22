using CSharpLabs.Supports;

namespace CSharpLabs.Lab2.Windows
{
    public partial class MainMenu : Form, ILabRunner
    {
        public string LabName => "WinformLab2";

        public MainMenu()
        {
            this.InitializeComponent();
            this.task_combobox.SelectedIndex = default(int);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex)
            {
                case 0: new LabTask1().ShowDialog(); break;
                case 1: new LabTask2().ShowDialog(); break;
                default: break;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string taskinfo_message = this.task_combobox.SelectedIndex == 0 ? "1) Вычислить выражение\n" +
                "2) Вычислить время падения тела.\n3) Имеет ли квадратное уравнение решение.\n4) Вычисление " +
                "площадей фигур" : "Создать структуру по предметной области и метод отображения данных";

            MessageBox.Show(taskinfo_message, "Информация задания");
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель лабораторной работы: изучение основ разработки визуальных" +
                "пользовательских интерфейсов для программирования ввода-вывода и основных" +
                "операторов языка C# на платформе .NET Framework.", "Краткие сведения");
        }

        private void ExitButton_Click(object sender, EventArgs e) => this.Close();

        public void RunLab() => this.ShowDialog();
    }
}