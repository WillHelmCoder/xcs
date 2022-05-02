using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace xcs.Models
{
    public class PersonModel : INotifyPropertyChanged
    {


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
        public ICommand PostAddXc { get; }




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
