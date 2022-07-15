using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using xcs.DTO.Account;

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

        //if (User == "will" && Password == "will")
        //{
            
            Preferences.Set("SessionStatus", "valid");
            Preferences.Set("TotalCoins", "1000");

            Application.Current.MainPage = new AppShell();
         
            var dto = new PostLoginInput
			{
                Email = User,
                Password = Password
			};

            var result = await App.Instance.Send<LoginResponse>("api/login", RestSharp.Method.Post, dto);

            if (!result.IsSuccessful)
			{
                //HANDLE ERRORS
                //var errorModel = App.Instance.GetErrorModel(result.Content);
                //ShowAlert(errorModel.Error);
			}

			var token = new JwtSecurityToken(result.Data.Token);
            var userEmail = token.Payload["useremail"].ToString();
            var userName = token.Payload["username"].ToString();
            //var userGuid = token.Payload["usertoken"].ToString();
            //var userRole = token.Payload["userrole"].ToString();

			App.Instance.StartSession(result.Data.Token);
			Preferences.Set("AuthToken", result.Data.Token);
			Preferences.Set("UserName", userName);
			Preferences.Set("UserEmail", userEmail);

			Preferences.Set("SessionStatus", "expired");

			//HANDLE REDIRECTION
		//}
	}
    public void Logout()
    {
        Preferences.Set("SessionStatus", "expired");
		
        Preferences.Remove("AuthToken");
        Preferences.Remove("UserName");
        Preferences.Remove("UserEmail");

		App.Instance.Logout();
	}

    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
