namespace cs_labs_winform
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.task_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex) 
            {
                case 0: new LabTask1().ShowDialog(); break;
                case 1: new Form3().ShowDialog(); break;
                    // запуск 2 задания
                default: break;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            switch (this.task_combobox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("1) Даны x, y, z. Вычислить a, b\n2) Вычислить время падения тела с высоты H с начальной скоростью V.\n" +
                        "3) Определить, имеет ли квадратное уравнение с коэффициентами a, b и c решение.\n" +
                        "4) Составить программу вычисления площадей различных геометрических фигур", "Информация задания");
                    break;
                case 1:
                    MessageBox.Show("1) Создать структуру согласно предметной области варианта\n" +
                        "2) Добавить метод отображения данных структуры.", "Информация задания");
                    break;
                default: break;
            }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цель лабораторной работы: изучение основ разработки визуальных" +
                "пользовательских интерфейсов для программирования ввода-вывода и основных" +
                "операторов языка C# на платформе .NET Framework.", "Краткие сведения");
        }

        private void ExitButton_Click(object sender, EventArgs e) => Application.Exit();

    }
}