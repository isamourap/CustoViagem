namespace AppMauiCustoViagem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public static object Db { get; internal set; }
    }
}
