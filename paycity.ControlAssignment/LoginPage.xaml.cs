using System.Windows.Input;

namespace paycity.ControlAssignment
{
    public partial class MainPage : ContentPage
    {
        public ICommand TapCommand => new Command
    <string>(async (url) => await Launcher.OpenAsync(url));

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

    }

}
