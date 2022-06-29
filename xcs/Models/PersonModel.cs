using System.ComponentModel;
namespace xcs.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        Guid guid;
        public Guid Guid
        {
            get { return guid; }
            set { guid = value; OnPropertyChanged(nameof(Guid)); }
        }
        int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value; OnPropertyChanged(nameof(Id));
            }
        }  
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }
        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged(nameof(LastName)); }
        }
        //string fullName;
        public string FullName => $"{FirstName} {" "} {LastName}";
        //public string FullName
        //{
        //    get { return fullName; }
        //  set { fullName = value; OnPropertyChanged(nameof(FullName)); }
        //}
        string email;
        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(nameof(Email)); }
        }
        int xipeCoins;
        public int XipeCoins
        {
            get { return xipeCoins; }
            set { xipeCoins = value; OnPropertyChanged(nameof(XipeCoins)); }
        }  
        bool talk;
        public bool Talk
        {
            get { return talk; }
            set { talk = value; OnPropertyChanged(nameof(Talk)); }
        }   
        public PersonModel()
        {
            

        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        public void SetProperty(string prop, string val)
        {

        }
        public void ClearFields()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }
    }
}
