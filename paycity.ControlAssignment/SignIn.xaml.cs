namespace paycity.ControlAssignment;


public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new HomePage());
    }
}