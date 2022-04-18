using System;

namespace SecondTask
{
    /// <inheritdoc cref="Exception"/>
    public class WrappedException : Exception
    {
        #region Constructors

        /// <inheritdoc cref="Exception"/>
        public WrappedException()
        {
        }

        /// <inheritdoc cref="Exception"/>
        public WrappedException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="Exception"/>
        public WrappedException(string message, InnerException innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}
