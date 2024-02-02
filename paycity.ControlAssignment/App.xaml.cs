namespace paycity.ControlAssignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(new HomePage());
        }
    }

}
