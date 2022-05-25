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
            string cycleKey = "cyclestartingdate";
            string daysKey = "daysofcycle";

            DateTime initDate = new DateTime(2022,12,12);
            DateTime cyclestartingdate = Preferences.Get(cycleKey, initDate);
            int daysofcycle = Preferences.Get(daysKey, 30);
            DateTime now = DateTime.Now;

            if (cyclestartingdate > now)
            {
                CycleStartingDate = cyclestartingdate;
                DaysOfCycle = daysofcycle;
            }
            else
            {
                Preferences.Set(cycleKey, DateTime.Now);
                Preferences.Set(daysKey, 30);
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
            var cycleStartingDate = CycleStartingDate ;
            var daysOfCycle = DaysOfCycle ;
            Preferences.Set("cyclestartingdate", cycleStartingDate);
            Preferences.Set("daysofcycle", daysOfCycle);

            Application.Current.MainPage = new AppShell();

            //Shell.Current.GoToAsync("///MainPage");
        }

    }
}
