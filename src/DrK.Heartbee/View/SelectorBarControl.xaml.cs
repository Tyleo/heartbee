using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Input;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrK.Heartbee.View
{
    public partial class SelectorBar : UserControl
    {
        public ICommand Image0Command { get; set; }
        public ICommand Image1Command { get; set; }
        public ICommand Image2Command { get; set; }
        public ICommand Image3Command { get; set; }

        public SelectorBar()
        {
            InitializeComponent();
        }

        private void Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image0Command.Execute(null);
        }

        private void Button_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image1Command.Execute(null);
        }

        private void Button_Tap_2(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image2Command.Execute(null);
        }

        private void Button_Tap_3(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Image3Command.Execute(null);
        }
    }
}
