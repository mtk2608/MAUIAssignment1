using System.Reflection;
using System.Windows.Input;

namespace paycity.ControlAssignment;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}



private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ComingSoon());
    }
}