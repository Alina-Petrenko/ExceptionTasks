using System;

namespace FirstTask
{
    /// <summary>
    /// <inheritdoc cref="Exception"/>
    /// </summary>
    public class WrappedException : Exception
    {
        #region Constructors

        /// <summary>
        /// <inheritdoc cref="Exception.Exception"/>
        /// </summary>
        public WrappedException()
        {
        }

        /// <summary>
        ///  <inheritdoc cref="Exception.Exception(string?)"/>
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception.Message"/></param>
        public WrappedException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc cref="Exception.Exception(string?, Exception?)"/>
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception.Message"/></param>
        /// <param name="innerException"><inheritdoc cref="Exception.InnerException"/></param>
        public WrappedException(string message, InnerException innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}
