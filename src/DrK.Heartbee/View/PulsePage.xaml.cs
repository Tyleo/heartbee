using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrK.Heartbee.View
{
    public partial class PulsePage : UserControl
    {


        public PulsePage()
        {
            InitializeComponent();
        }

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ((DrK.Heartbee.App)App.Current).MainViewModel.MultibeatViewModel.Offset = 0;
            
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ((DrK.Heartbee.App)App.Current).MainViewModel.PulseViewModel.ChangePulse();
        }
    }
}
