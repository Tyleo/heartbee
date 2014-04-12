using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Devices;
using System.Windows.Media;

namespace DrK.Heartbee.View
{
    public partial class CenterHeartbeat : UserControl
    {
        public CenterHeartbeat()
        {
            InitializeComponent();
        }

        public void readCamera(object sender, EventArgs args)
        {

            // Initialize camera
            PhotoCamera cam = new Microsoft.Devices.PhotoCamera();
            cam.FlashMode = FlashMode.On;

            int[] camData = new int[(int)cam.PreviewResolution.Width*(int)cam.PreviewResolution.Height];
            cam.GetPreviewBufferArgb32(camData);

            int redAvg = 0;

            for(int i = 0; i < camData.Length; i++)
            {
                camData[i] += (camData[i] >> 16) % 256;
            }
            redAvg /= camData.Length;
            Console.WriteLine(redAvg);
        }
    }
}
