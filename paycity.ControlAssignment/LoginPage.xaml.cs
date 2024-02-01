using Microsoft.Maui.Controls;

namespace paycity.ControlAssignment
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            Navigation.PushAsync(new SearchPage());
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignIn());
        }


        private void RegisterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUp());
        }
    }

}
