using System;
using System.ComponentModel;
using System.Diagnostics;

namespace DrK.Heartbee.Utilities.Extensions
{
    /// <summary>
    /// Provides extensions for the Object class.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ObjectExtensions
    {
        /// <summary>
        /// Returns true if the current object is null.
        /// </summary>
        /// <param name="this">
        /// The current object.
        /// </param>
        /// <returns>
        /// True if the current object is null; false otherwise.
        /// </returns>
        public static bool IsNull(this object @this)
        {
            return @this == null;
        }

        /// <summary>
        /// Returns an array with its only element being the current object.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the current object.
        /// </typeparam>
        /// <param name="this">
        /// The current object.
        /// </param>
        /// <returns>
        /// An array with its only element being the current object.
        /// </returns>
        public static T[] AsOneItemArray<T>(this T @this)
        {
            return new[] { @this };
        }

        /// <summary>
        /// Throws a NullReferenceException if the current object is null.
        /// </summary>
        /// <param name="this">
        /// The current object.
        /// </param>
        /// <param name="message">
        /// A System.String that describes the error. The content of message is
        /// intended to be understood by humans. The caller of this constructor
        /// is required to ensure that this string has been localized for the
        /// current system culture.
        /// </param>
        [Conditional("DEBUG")]
        public static void ThrowNullReferenceExceptionIfNull(this object @this, string message)
        {
            if (@this == null) throw new NullReferenceException(message);
        }

        /// <summary>
        /// Throws an ArgumentNullException if the current object is null.
        /// </summary>
        /// <param name="this">
        /// The current object.
        /// </param>
        /// <param name="paramName">
        /// The name of the parameter that caused the exception.
        /// </param>
        /// <param name="message">
        /// A message that describes the error.
        /// </param>
        [Conditional("DEBUG")]
        public static void ThrowArgumentNullExceptionIfNull(this object @this, string paramName, string message = null)
        {
            if (@this == null) throw new ArgumentNullException(paramName, message);
        }
    }
}
