using Microsoft.Maui.Controls;

namespace paycity.ControlAssignment
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();

            Navigation.PushAsync(new HomePage());

        }


       

    }

}
