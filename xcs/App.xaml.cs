namespace xcs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		if (Preferences.Get("SessionStatus", "Default")!="valid") {

			MainPage = new NavigationPage(new Login());
			//MainPage = new AppShell();
		}
        else
        {
			
			
			MainPage = new AppShell();

	
		}		
	}
}
