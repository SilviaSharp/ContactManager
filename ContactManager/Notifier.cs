using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace ContactManager
{
    [Serializable]
    public abstract class Notifier: INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
