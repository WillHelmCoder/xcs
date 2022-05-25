using xcs.Models;

namespace xcs;

public partial class ProfilePage : ContentPage
{
	

	public ProfilePage()
	{
		InitializeComponent();
		BindingContext = new ProfilePageViewModel();
	}


}

