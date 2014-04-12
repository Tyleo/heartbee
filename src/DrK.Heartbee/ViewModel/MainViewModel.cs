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

        public SelectorBarViewModel SelectorBarViewModel { get { return _selectorBarViewModel; } }

        public MainViewModel(SelectorBarViewModel selectorBarViewModel)
        {
            _selectorBarViewModel = selectorBarViewModel;
        }
    }
}
