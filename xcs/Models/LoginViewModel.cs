using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcs.Models
{
    internal class LoginViewModel
    {
        public string User { get; set; }
        public string Password { get; set; }
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
                Application.Current.MainPage = new AppShell();


               //await Shell.Current.GoToAsync("MainPage");



            }
        }
        public void Logout()
        {
            Preferences.Set("SessionStatus", "expired");
        }

    }
}
