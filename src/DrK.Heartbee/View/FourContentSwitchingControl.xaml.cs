using DrK.Heartbee.Utilities.Classes;
using DrK.Heartbee.Utilities.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace DrK.Heartbee.View
{
    public partial class FourContentSwitchingControl :
        UserControl
    {
        public static readonly DependencyProperty Content0Property = DependencyProperty.Register(
            "Content0",
            typeof(UIElement),
            typeof(FourContentSwitchingControl),
            new PropertyMetadata(new Grid())
        );

        public static readonly DependencyProperty Content1Property = DependencyProperty.Register(
            "Content1",
            typeof(UIElement),
            typeof(FourContentSwitchingControl),
            new PropertyMetadata(new Grid())
        );

        public static readonly DependencyProperty Content2Property = DependencyProperty.Register(
            "Content2",
            typeof(UIElement),
            typeof(FourContentSwitchingControl),
            new PropertyMetadata(new Grid())
        );

        public static readonly DependencyProperty Content3Property = DependencyProperty.Register(
            "Content3",
            typeof(UIElement),
            typeof(FourContentSwitchingControl),
            new PropertyMetadata(new Grid())
        );

        private readonly ActionCommand _selectContent0ActionCommand;
        private readonly ActionCommand _selectContent1ActionCommand;
        private readonly ActionCommand _selectContent2ActionCommand;
        private readonly ActionCommand _selectContent3ActionCommand;

        private UIElement _currentContent = new Grid();
        private byte _currentContentIndex = 0;

        public ICommand SelectContent0Command { get { return _selectContent0ActionCommand; } }
        public ICommand SelectContent1Command { get { return _selectContent1ActionCommand; } }
        public ICommand SelectContent2Command { get { return _selectContent2ActionCommand; } }
        public ICommand SelectContent3Command { get { return _selectContent3ActionCommand; } }


        public UIElement Content0
        {
            get { return (UIElement)GetValue(Content0Property); }
            set
            {
                SetValue(Content0Property, value);
                if (_currentContentIndex == 0)
                {
                    CurrentContent = Content0;
                }
            }
        }

        public UIElement Content1
        {
            get { return (UIElement)GetValue(Content1Property); }
            set
            {
                SetValue(Content1Property, value);
                if (_currentContentIndex == 1)
                {
                    CurrentContent = Content1;
                }
            }
        }

        public UIElement Content2
        {
            get { return (UIElement)GetValue(Content2Property); }
            set
            {
                SetValue(Content2Property, value);
                if (_currentContentIndex == 2)
                {
                    CurrentContent = Content2;
                }
            }
        }

        public UIElement Content3
        {
            get { return (UIElement)GetValue(Content3Property); }
            set
            {
                SetValue(Content3Property, value);
                if (_currentContentIndex == 3)
                {
                    CurrentContent = Content3;
                }
            }
        }

        private UIElement CurrentContent
        {
            get { return _currentContent; }
            set
            {
                _currentContent = value;
                while (AssControl.Children.Any())
                {
                    AssControl.Children.RemoveAt(0);
                }
                AssControl.Children.Add(value);
            }
        }

        public void SelectContent0()
        {
            _currentContentIndex = 0;
            CurrentContent = Content0;
        }

        public void SelectContent1()
        {
            _currentContentIndex = 1;
            CurrentContent = Content1;
        }

        public void SelectContent2()
        {
            _currentContentIndex = 2;
            CurrentContent = Content2;
        }

        public void SelectContent3()
        {
            _currentContentIndex = 3;
            CurrentContent = Content3;
        }

        public FourContentSwitchingControl()
        {
            _selectContent0ActionCommand = new ActionCommand((o) => SelectContent0());
            _selectContent1ActionCommand = new ActionCommand((o) => SelectContent1());
            _selectContent2ActionCommand = new ActionCommand((o) => SelectContent2());
            _selectContent3ActionCommand = new ActionCommand((o) => SelectContent3());

            InitializeComponent();
        }
    }
}
