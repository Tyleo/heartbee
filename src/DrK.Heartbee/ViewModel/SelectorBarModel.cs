using DrK.Heartbee.Utilities.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrK.Heartbee.ViewModel
{
    public sealed class SelectorBarModel :
        INotifyPropertyChanged
    {
        private readonly NotifyPropertyChangedManager _notifyPropertyChangedManager;

        private readonly string _image0Source0;
        private readonly string _image0Source1;
        private readonly string _image1Source0;
        private readonly string _image1Source1;
        private readonly string _image2Source0;
        private readonly string _image2Source1;
        private readonly string _image3Source0;
        private readonly string _image3Source1;

        private byte _selectedIndex;

        public string Image0Source
        {
            get
            {
                if (_selectedIndex == 0)
                {
                    return _image0Source1;
                }

                return _image0Source0;
            }
        }

        public string Image1Source
        {
            get
            {
                if (_selectedIndex == 1)
                {
                    return _image1Source1;
                }

                return _image1Source0;
            }
        }

        public string Image2Source
        {
            get
            {
                if (_selectedIndex == 2)
                {
                    return _image2Source1;
                }

                return _image2Source0;
            }
        }

        public string Image3Source
        {
            get
            {
                if (_selectedIndex == 3)
                {
                    return _image3Source1;
                }

                return _image3Source0;
            }
        }

        public byte SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;

            }
        }

        public SelectorBarModel(
            string image0Source0,
            string image0Source1,
            string image1Source0,
            string image1Source1,
            string image2Source0,
            string image2Source1,
            string image3Source0,
            string image3Source1,
            byte selectedIndex = 0
        )
        {
            _image0Source0 = image0Source0;
            _image0Source1 = image0Source1;
            _image1Source0 = image1Source0;
            _image1Source1 = image1Source1;
            _image2Source0 = image2Source0;
            _image2Source1 = image2Source1;
            _image3Source0 = image3Source0;
            _image3Source1 = image3Source1;
            _selectedIndex = selectedIndex;
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }
    }
}
