namespace CSharpLabs
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LabsLoader.LabsSelecter());
        }
    }
}