using System.Reflection;

namespace paycity.ControlAssignment;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
    }


    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ComingSoon());
    }
}