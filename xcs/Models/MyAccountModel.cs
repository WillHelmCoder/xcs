using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace xcs.Models
{
    public class MyAccountModel : INotifyPropertyChanged
    {
        int totalXipecoins;
        public int TotalXipeCoins
        {
            get { return totalXipecoins; }
            set { totalXipecoins = value; OnPropertyChanged(nameof(TotalXipeCoins)); }
        }


        int xipecoinsGiven;
        public int XipeCoinsGiven
        {
            get { return xipecoinsGiven; }
            set { xipecoinsGiven = value; OnPropertyChanged(nameof(XipeCoinsGiven)); }
        }

        int xipeCoinsToGive;
        public int XipeCoinsToGive
        {
            get { return xipeCoinsToGive; }
            set { xipeCoinsToGive = value; OnPropertyChanged(nameof(XipeCoinsToGive)); }
        }

        public ICommand GiveXipeCoins { get; }

        public MyAccountModel()
        {
            GiveXipeCoins = new Command(FnGiveXipeCoins);
            TotalXipeCoins = FnTotalXipeCoins();
            XipeCoinsGiven = 0;
            XipeCoinsToGive = FnXipeCoinsToGive();
        }


        public int FnXipeCoinsToGive()
        {
            int XCtoGive = TotalXipeCoins - XipeCoinsGiven;
            return XCtoGive;
        }
        public int FnTotalXipeCoins()
        {
            return 30;

        }

        public void FnGiveXipeCoins()
        {
            if (XipeCoinsToGive > 0)
            {
                TotalXipeCoins = TotalXipeCoins - 1;
                XipeCoinsGiven = XipeCoinsGiven + 1;

            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        public void SetProperty(string prop, string val)
        {

        }

    }
}
