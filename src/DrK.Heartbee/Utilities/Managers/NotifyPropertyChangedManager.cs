using DrK.Heartbee.Utilities.Extensions;
using System.ComponentModel;

namespace DrK.Heartbee.Utilities.Managers
{
    /// <summary>
    /// Provides a surrogate implementation of the INotifyPropertyChanged interface.
    /// </summary>
    public sealed class NotifyPropertyChangedManager :
        INotifyPropertyChanged
    {
        private readonly NotifyPropertyChangedAsyncFlags _notifyPropertyChangedAsyncFlags;
        private readonly object _sender;

        /// <summary>
        /// Flags which determine which methods and events will be handled
        /// asynchronously in the NotifyPropertyChangedManager.
        /// </summary>
        public NotifyPropertyChangedAsyncFlags NotifyPropertyChangedAsyncFlags { get { return _notifyPropertyChangedAsyncFlags; } }

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Creates a new NotifyPropertyChangedManager.
        /// </summary>
        /// <param name="sender">
        /// The object which this NotifyPropertyChangedManager is implementing
        /// the INotifyPropertyChanged interface for.
        /// </param>
        /// <param name="notifyPropertyChangedAsyncFlags">
        /// Flags which determine which methods and events will be handled
        /// asynchronously.
        /// </param>
        public NotifyPropertyChangedManager(object sender, NotifyPropertyChangedAsyncFlags notifyPropertyChangedAsyncFlags = NotifyPropertyChangedAsyncFlags.All)
        {
            sender.ThrowArgumentNullExceptionIfNull("sender", "Argument \"sender\" is null.");

            _notifyPropertyChangedAsyncFlags = notifyPropertyChangedAsyncFlags;

            _sender = sender;
        }

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property that changed.
        /// </param>
        public void InvokePropertyChanged(string propertyName)
        {
            propertyName.ThrowArgumentNullExceptionIfNull("propertyName", "Argument \"propertyName\" is null.");

            if (_notifyPropertyChangedAsyncFlags.HasFlag(NotifyPropertyChangedAsyncFlags.RaisePropertyChangedAsync))
            {
                PropertyChanged.InvokeIfInstantiatedAsync(_sender, new PropertyChangedEventArgs(propertyName));
            }
            else
            {
                PropertyChanged.InvokeIfInstantiated(_sender, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
