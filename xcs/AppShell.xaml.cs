namespace xcs;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("Login", typeof(Login));

        Routing.RegisterRoute("MainPage", typeof(MainPage));        
        Routing.RegisterRoute("Profile", typeof(ProfilePage));
        Routing.RegisterRoute("Settings", typeof(SettingsPage));



         
    }
}
