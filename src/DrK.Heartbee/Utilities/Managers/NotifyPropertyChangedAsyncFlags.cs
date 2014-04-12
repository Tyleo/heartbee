using System;

namespace DrK.Heartbee.Utilities.Managers
{
    /// <summary>
    /// Flags which determine which methods and events will be handled
    /// asynchronously in a NotifyPropertyChangedManager.
    /// </summary>
    [Flags]
    public enum NotifyPropertyChangedAsyncFlags
    {
        /// <summary>
        /// No methods or events will be handled asynchronously.
        /// </summary>
        None = 0,

        /// <summary>
        /// The PropertyChanged event will be raised in a separate Task.
        /// </summary>
        RaisePropertyChangedAsync = 1,

        /// <summary>
        /// Eligible event handlers for the PropertyChanged event will be
        /// invoked in a separate Task.
        /// </summary>
        HandlePropertyChangedAsync = RaisePropertyChangedAsync << 1,

        /// <summary>
        /// Every eligible method and event will be invoked in a separate Task.
        /// </summary>
        All =
            RaisePropertyChangedAsync |
            HandlePropertyChangedAsync
    }
}
