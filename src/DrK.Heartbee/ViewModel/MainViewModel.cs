using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrK.Heartbee.ViewModel
{
    public sealed class MainViewModel
    {
        private readonly SelectorBarViewModel _selectorBarViewModel;
        private readonly MultibeatViewModel _multibeatControlViewModel;
        private readonly PulseViewModel _pulseViewModel;

        public SelectorBarViewModel SelectorBarViewModel { get { return _selectorBarViewModel; } }
        public MultibeatViewModel MultibeatViewModel { get { return _multibeatControlViewModel; } }
        public PulseViewModel PulseViewModel { get { return _pulseViewModel; } }

        public MainViewModel(SelectorBarViewModel selectorBarViewModel, MultibeatViewModel multibeatControlViewModel, PulseViewModel pulseViewModel)
        {
            _selectorBarViewModel = selectorBarViewModel;
            _multibeatControlViewModel = multibeatControlViewModel;
            _pulseViewModel = pulseViewModel;
        }
    }
}
