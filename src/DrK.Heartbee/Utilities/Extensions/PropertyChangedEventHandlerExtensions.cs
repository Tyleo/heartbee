using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DrK.Heartbee.Utilities.Extensions
{
    /// <summary>
    /// Provides extensions for the PropertyChangedEventHandler class.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class PropertyChangedEventHandlerExtensions
    {
        private static void InvokeIfInstantiated(object state)
        {
            Tuple<PropertyChangedEventHandler, object, PropertyChangedEventArgs> @params = (Tuple<PropertyChangedEventHandler, object, PropertyChangedEventArgs>)state;

            PropertyChangedEventHandler @this = @params.Item1;
            object sender = @params.Item2;
            PropertyChangedEventArgs e = @params.Item3;

            @this.InvokeIfInstantiated(sender, e);
        }

        /// <summary>
        /// Invokes a PropertyChangedEventHandler if it is not null.
        /// </summary>
        /// <param name="this">
        /// The PropertyChangedEventHandler to invoke.
        /// </param>
        /// <param name="sender">
        /// The object invoking the PropertyChangedEventHandler.
        /// </param>
        /// <param name="e">
        /// Data for the PropertyChangedEventHandler.
        /// </param>
        public static void InvokeIfInstantiated(this PropertyChangedEventHandler @this, object sender, PropertyChangedEventArgs e)
        {
            if (!@this.IsNull())
            {
                @this(sender, e);
            }
        }

        /// <summary>
        /// Invokes a PropertyChangedEventHandler in a separate Task if it is not null.
        /// </summary>
        /// <param name="this">
        /// The PropertyChangedEventHandler to invoke.
        /// </param>
        /// <param name="sender">
        /// The object invoking the PropertyChangedEventHandler.
        /// </param>
        /// <param name="e">
        /// Data for the PropertyChangedEventHandler.
        /// </param>
        /// <returns>
        /// The Task which the PropertyChangedEventHandler will be invoked in.
        /// </returns>
        public static Task InvokeIfInstantiatedAsync(this PropertyChangedEventHandler @this, object sender, PropertyChangedEventArgs e)
        {
            Task @return = new Task(InvokeIfInstantiated, Tuple.Create(@this, sender, e));
            @return.Start();
            return @return;
        }
    }
}
