using System.Collections.ObjectModel;
using System.ComponentModel;
using xcs.Services;

namespace xcs.Models;
public class PersonPageViewModel : INotifyPropertyChanged
{
    private readonly Repository _repository;
    public ObservableCollection<PersonModel> Persons { get; set; } = new ObservableCollection<PersonModel>();
    public MyAccountModel Account { get; set; } = new MyAccountModel();
    public bool IsCycleEnd { get; set; }
    public int daysLeft;
    public int DaysLeft
    {
        get { return daysLeft; }
        set { daysLeft = value; OnPropertyChanged(nameof(DaysLeft)); }
    }
    public Command<PersonModel> GiveXipecoins { get; }
    public Command<PersonModel> TakeBackXipecoins { get; }
    public Command<PersonModel> LaunchModal { get; }
    public Command<PersonModel> Talk { get; }
    public PersonPageViewModel()
    {
        GiveXipecoins = new Command<PersonModel>((x) => FnGiveXipeCoins(x));        
        TakeBackXipecoins = new Command<PersonModel>((x) => FnTakeBackXipecoins(x));       
        LaunchModal = new Command<PersonModel>((x) => FnModal(x));           
        FnCycleChecker();
        DataService dataService = new DataService();
        Persons = dataService.Persons;       
        Talk = new Command<PersonModel>((x) => FnTalk(x));
    }
    public event PropertyChangedEventHandler PropertyChanged;
    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    public void FnModal(PersonModel person)
    {
        var Pagina = new ModalPage(person, Talk);
        Application.Current.MainPage.Navigation.PushModalAsync(Pagina);
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
    public void FnTalk(PersonModel person)
    {
        if (Account.XipeCoinsToGive > 0)
        {     
            var x = person;
            Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().Talk = person.Talk;
        }
    }
    public void FnTakeBackXipecoins(PersonModel person)
    {
        if (Account.XipeCoinsToGive < Account.TotalXipeCoins)
        {
            if (Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins > 0)
            {
                Account.XipeCoinsToGive = Account.XipeCoinsToGive + 1;
                Account.XipeCoinsGiven = Account.XipeCoinsGiven - 1;
                var x = person;
                Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins = Persons.Where(w => w.Guid == person.Guid).SingleOrDefault().XipeCoins - 1;
            }
        }
    }
    public void FnCycleChecker()
    {
        DateTime startingDate = DateTime.Parse(Preferences.Get("cyclestartingdate", "Default"));
        int cycleDays = int.Parse(Preferences.Get("daysofcycle", "Default"));
        DateTime endingDate = startingDate.AddDays(cycleDays);
        DaysLeft = (endingDate - DateTime.Now).Days;
        if (DaysLeft <= 2)
        {
            IsCycleEnd = true;
        }
    }
}

