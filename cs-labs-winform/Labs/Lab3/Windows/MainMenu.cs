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
                case 1: new LabTask6().ShowDialog(); break;
                case 2: new LabTask7().ShowDialog(); break;
                case 3: new LabTask8().ShowDialog(); break;
                default: break;
            }
        }

        private void HelpButton_Click(object? sender, EventArgs e)
        {
            string taskinfo_message = string.Empty;
            switch (this.task_combobox.SelectedIndex)
            {
                case 0: taskinfo_message = "����� ����� ������������ ����. ����������� ���� ����� ���� �� ������ ������ ��������� eps > 0."; break;
                case 1: taskinfo_message = "���������� �������� �������� ������� � ������ ����� ������� � ����� ����� ���������� ��������."; break;
                case 2: taskinfo_message = "���� ����� ����� N, ��������� �� ��� ������ ����� 0 � 5, �������� ������� ������� ��������� ����."; break;
                case 3: taskinfo_message = "���� ����� ����� N (N > 0), ��������� ���� ����, ����� ����� 1! +2! + 3! +...+N!"; break;
            }
            MessageBox.Show(taskinfo_message, "���������� �������");
        }

        private void InfoButton_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("���� ������������ ������: �������� ����� ���������������� ������ �� ����� C#" +
                "� ��������� ������� ������ � ������� � ���������� ���������� �� ��������� .NET Framework.", 
                "������� ��������");
        }

        private void ExitButton_Click(object? sender, EventArgs e) => this.Close();
    }
}