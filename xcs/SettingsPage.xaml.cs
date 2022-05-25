using xcs.Models;

namespace xcs;

public partial class SettingsPage : ContentPage
{
	

	public SettingsPage()
	{
		InitializeComponent();
		BindingContext = new SettingsPageViewModel();
	}


}

