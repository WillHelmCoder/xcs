using xcs.Models;

namespace xcs;

public partial class Login : ContentPage
{
	

	public Login()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
  



	}


}

