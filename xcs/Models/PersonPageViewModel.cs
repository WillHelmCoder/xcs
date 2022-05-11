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
        public Command PostPeople { get; }
        public Command<PersonModel> GiveXipecoins { get; }
        public Command<PersonModel> TakeBackXipecoins { get; }
        public Command<PersonModel> InviteCoffee { get; }
        public Command<PersonModel> RetireCoffee { get; }


        public PersonPageViewModel()
        {
            PostPeople = new Command(AddPerson);
            GiveXipecoins = new Command<PersonModel>((x)=>FnGiveXipeCoins(x));
            TakeBackXipecoins = new Command<PersonModel>((x)=>FnTakeBackXipecoins(x));
            
            InviteCoffee = new Command<PersonModel>((x)=> FnInviteCoffeee(x));
            RetireCoffee = new Command<PersonModel>((x)=>FnRetireCoffee(x));

            Persons.Add(new PersonModel { Id = 1, Guid = Guid.NewGuid(), Email = "Will@gmail.com", LastName = "Espinola", FirstName = "Will" });
            
            Preferences.Set("Sesion", "WEEEEY");
            Account.Name = Preferences.Get("Sesion", "Default");
            

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public void AddPerson()
        {
            Persons.Add(new PersonModel {Id=1, Guid= Guid.NewGuid(), Email = "Patty@xipe.com", LastName = "aa", FirstName = "aa" });
            Preferences.Set("Sesion", "Botoneado");
            Account.Name=Preferences.Get("Sesion", "Default"); ;
        }

        public void FnGiveXipeCoins(PersonModel person)
        {
            if (Account.XipeCoinsToGive > 0)
            {
                Account.XipeCoinsToGive = Account.XipeCoinsToGive - 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven + 1;
                var x = person;   
                Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins = Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins + 1;
            }

        }

        public void FnTakeBackXipecoins(PersonModel person)
        {
            if (Account.XipeCoinsToGive < Account.TotalXipeCoins )
            {
                Account.XipeCoinsToGive = Account.XipeCoinsToGive + 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven - 1;
                var x = person;
                Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins = Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins - 1;
            }

        }

        public void FnInviteCoffeee(PersonModel person)
        {
            if (Account.XipeCoinsToGive > 0)
            {
                Account.XipeCoinsToGive = Account.XipeCoinsToGive - 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven + 1;
                var x = person;
                Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().Coffee = Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().Coffee + 1;
            }

        }

        public void FnRetireCoffee(PersonModel person)
        {
            if (Account.XipeCoinsToGive > 0)
            {
                Account.XipeCoinsToGive = Account.XipeCoinsToGive - 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven + 1;
                var x = person;
                Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().Coffee = Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().Coffee - 1;
            }

        }


    }
}
