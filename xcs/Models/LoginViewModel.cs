using System.ComponentModel;
namespace xcs.Models;


internal class LoginViewModel : INotifyPropertyChanged
{
    string user;
    public string User
    {
        get { return user; }
        set {user = value; OnPropertyChanged(nameof(User));}
    }

    string password;
    public string Password {
        get { return password; }
        set { password = value; OnPropertyChanged(nameof(Password)); }
    }


    public Command LoginCommand { get; set; }
    public Command LogoutCommand { get; set; }


    public LoginViewModel()
    {
        LoginCommand = new Command(Login);
        LogoutCommand = new Command(Logout);
    }
    public async void Login()
    {

        if (User == "will" && Password == "will")
        {
            
            Preferences.Set("SessionStatus", "valid");
            Preferences.Set("TotalCoins", "1000");

            Application.Current.MainPage = new AppShell();
            
            //aqui poner request al server    
        }
    }
    public void Logout()
    {
        Preferences.Set("SessionStatus", "expired");
    }

    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
