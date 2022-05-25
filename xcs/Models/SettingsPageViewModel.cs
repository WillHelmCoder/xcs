using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xcs.Models
{
    internal class SettingsPageViewModel
    {
        public int DaysOfCycle { get; set; }
        public DateTime CycleStartingDate { get; set; }
        public Command LogoutCommand { get; }
        public Command SaveSettingsCommand { get; }

        public SettingsPageViewModel()
        {
           
            var cyclestartingdate = DateTime.Parse(Preferences.Get("cyclestartingdate", "12/12/2022"));
            var daysofcycle = int.Parse(Preferences.Get("daysofcycle", "Default"));
            if (cyclestartingdate != null || daysofcycle != 0)
            {
                CycleStartingDate = cyclestartingdate;
                DaysOfCycle = daysofcycle;
            }
            else
            {
                Preferences.Set("cyclestartingdate", DateTime.Now.ToString());
                Preferences.Set("daysofcycle", "30");
                    //Recordar cuidar este detalle para cuando la app es nueva
            }
            LogoutCommand = new Command(Logout);
            SaveSettingsCommand = new Command(SaveCycleSettings);

        }

        public void Logout()
        {
            Preferences.Set("SessionStatus", "expired");

            Application.Current.MainPage = new Login();
        }

        public void SaveCycleSettings()
        {
            string cycleStartingDate = CycleStartingDate.ToString();
            string daysOfCycle = DaysOfCycle.ToString();
            Preferences.Set("cyclestartingdate", cycleStartingDate);
            Preferences.Set("daysofcycle", daysOfCycle);

            Application.Current.MainPage = new AppShell();

            //Shell.Current.GoToAsync("///MainPage");
        }

    }
}
