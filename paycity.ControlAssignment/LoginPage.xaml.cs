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


        public void HomePageClicked(object sender, EventArgs e)
        {
            // Navigate to the second page
            Navigation.PushAsync(new HomePage());

        }

    }

}
