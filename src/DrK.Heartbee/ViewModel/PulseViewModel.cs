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
    public sealed class PulseViewModel :
        INotifyPropertyChanged
    {
        private readonly NotifyPropertyChangedManager _notifyPropertyChangedManager;

        private const string RED_PULSE_PATH = "/Assets/pulse-red.png";
        private const string GREEN_PULSE_PATH = "/Assets/pulse-green.png";

        private string _pulseSource = RED_PULSE_PATH;

        public void ChangePulse()
        {
            if (PulseSource.Equals(RED_PULSE_PATH))
            {
                PulseSource = GREEN_PULSE_PATH;
            }
            else
            {
                PulseSource = RED_PULSE_PATH;
            }
        }

        public string PulseSource
        {
            get
            {
                return _pulseSource;
            }
            private set
            {
                _pulseSource = value;
                _notifyPropertyChangedManager.InvokePropertyChanged("PulseSource");
            }
        }

        public PulseViewModel()
        {
            _notifyPropertyChangedManager = new NotifyPropertyChangedManager(this, NotifyPropertyChangedAsyncFlags.None);
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
