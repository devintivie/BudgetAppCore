using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BaseClassesCore
{
    public class BaseINPC : INotifyPropertyChanged
    {
        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
