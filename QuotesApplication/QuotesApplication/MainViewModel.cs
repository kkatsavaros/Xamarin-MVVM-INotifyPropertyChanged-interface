using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using Xamarin.Forms;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuotesApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {


        private string _userName;   //propfull + Tab.

        public string UserName      // 'Οτι γράφω στο Entry πηγαίνει στο property UserName.
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged("UserName"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
