using DrK.Heartbee.Utilities.Classes;
using DrK.Heartbee.Utilities.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DrK.Heartbee.ViewModel
{
    public sealed class MultibeatViewModel :
        INotifyPropertyChanged
    {
        private NotifyPropertyChangedManager _notifyPropertyChangedManager;
        private int _offset;

        public int Offset
        {
            get
            {
                return _offset;
            }
            set
            {
                _offset = value;
                _notifyPropertyChangedManager.InvokePropertyChanged("Offset");
            }
        }

        public MultibeatViewModel()
        {
            _notifyPropertyChangedManager = new NotifyPropertyChangedManager(this, NotifyPropertyChangedAsyncFlags.None);
            _offset = -480;
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                _notifyPropertyChangedManager.PropertyChanged += value;
            }
            remove
            {
                _notifyPropertyChangedManager.PropertyChanged -= value;
            }
        }
    }
}
