using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace xcs.Models
{
    public class PersonPageViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<PersonModel> Persons { get; set; } = new ObservableCollection<PersonModel>();
        public MyAccountModel Account { get; set; } = new MyAccountModel();

        public PersonModel Person { get; set; } = new PersonModel();
        public ICommand PostPeople { get; }
        public ICommand GiveXipecoins { get; }


        public PersonPageViewModel()
        {
            PostPeople = new Command(AddPerson);

            GiveXipecoins = new Command(FnGiveXipeCoins);

            Persons.Add(new PersonModel { Email = "Will@gmail.com", LastName = "Espinola", FirstName = "Orci" });

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void AddPerson()
        {
            Persons.Add(new PersonModel { Email = "Will@gmail.com", LastName = "Espinola", FirstName = "Orci" });
        }

        public void FnGiveXipeCoins()
        {
            if (Account.XipeCoinsToGive > 0)
            {
                Account.TotalXipeCoins = Account.TotalXipeCoins - 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven + 1;
                var x = GiveXipecoins.GetType();
            
  
                   
}
                //Persons.Where(w => w.Email == Receiver.Email).SingleOrDefault().XipeCoins = Persons.Where(w => w.Email == Receiver.Email).SingleOrDefault().XipeCoins + 1;
            }


        }


    }
}
