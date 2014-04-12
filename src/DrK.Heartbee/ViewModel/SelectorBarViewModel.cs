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
    public sealed class SelectorBarViewModel :
        INotifyPropertyChanged
    {
        private readonly NotifyPropertyChangedManager _notifyPropertyChangedManager;

        private readonly ActionCommand _selectImage0Command;
        private readonly ActionCommand _selectImage1Command;
        private readonly ActionCommand _selectImage2Command;
        private readonly ActionCommand _selectImage3Command;

        private readonly string _image0Source0;
        private readonly string _image0Source1;
        private readonly string _image1Source0;
        private readonly string _image1Source1;
        private readonly string _image2Source0;
        private readonly string _image2Source1;
        private readonly string _image3Source0;
        private readonly string _image3Source1;

        private byte _selectedIndex;

        public ICommand SelectImage0Command { get { return _selectImage0Command; } }
        public ICommand SelectImage1Command { get { return _selectImage1Command; } }
        public ICommand SelectImage2Command { get { return _selectImage2Command; } }
        public ICommand SelectImage3Command { get { return _selectImage3Command; } }

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
            private set
            {
                var oldIndex = _selectedIndex;
                _selectedIndex = value;

                InvokePropertyChangedViaByte(oldIndex);
                InvokePropertyChangedViaByte(_selectedIndex);
            }
        }

        private void InvokePropertyChangedViaByte(byte index)
        {
            switch (index)
            {
                case 0:
                    _notifyPropertyChangedManager.InvokePropertyChanged("Image0Source");
                    break;
                case 1:
                    _notifyPropertyChangedManager.InvokePropertyChanged("Image1Source");
                    break;
                case 2:
                    _notifyPropertyChangedManager.InvokePropertyChanged("Image2Source");
                    break;
                case 3:
                    _notifyPropertyChangedManager.InvokePropertyChanged("Image3Source");
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _notifyPropertyChangedManager.PropertyChanged += value; }
            remove { _notifyPropertyChangedManager.PropertyChanged -= value; }
        }

        public void SelectImage0()
        {
            SelectedIndex = 0;
        }

        public void SelectImage1()
        {
            SelectedIndex = 1;
        }

        public void SelectImage2()
        {
            SelectedIndex = 2;
        }

        public void SelectImage3()
        {
            SelectedIndex = 3;
        }

        public SelectorBarViewModel(
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
            _notifyPropertyChangedManager = new NotifyPropertyChangedManager(this, NotifyPropertyChangedAsyncFlags.None);

            _selectImage0Command = new ActionCommand(
                (o) =>
                {
                    SelectImage0();
                });
            _selectImage1Command = new ActionCommand(
                (o) =>
                {
                    SelectImage1();
                });
            _selectImage2Command = new ActionCommand(
                (o) =>
                {
                    SelectImage2();
                });
            _selectImage3Command = new ActionCommand(
                (o) =>
                {
                    SelectImage3();
                });

            _image0Source0 = image0Source0;
            _image0Source1 = image0Source1;
            _image1Source0 = image1Source0;
            _image1Source1 = image1Source1;
            _image2Source0 = image2Source0;
            _image2Source1 = image2Source1;
            _image3Source0 = image3Source0;
            _image3Source1 = image3Source1;
            SelectedIndex = selectedIndex;
        }
    }
}
