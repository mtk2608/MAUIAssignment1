using System.Reflection;

namespace paycity.ControlAssignment;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    async void OnButtonClicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        string id = btn.StyleId;

        Assembly assembly = GetType().GetTypeInfo().Assembly;
        Type pageType = assembly.GetType("ControlGallery.Views.XAML." + id);
        Page page = (Page)Activator.CreateInstance(pageType);
        await Navigation.PushAsync(page);
    }
}