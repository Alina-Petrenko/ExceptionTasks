using System;

namespace SecondTask
{
    /// <inheritdoc cref="Exception"/>
    public class InnerException : Exception
    {
        #region Constructors

        /// <inheritdoc cref="Exception"/>
        public InnerException()
        {
        }

        /// <inheritdoc cref="Exception"/>
        public InnerException(string message) : base(message)
        {
        }

        /// <inheritdoc cref="Exception"/>
        public InnerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}
