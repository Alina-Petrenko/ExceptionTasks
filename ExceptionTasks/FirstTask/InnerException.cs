using System;

namespace FirstTask
{
    /// <summary>
    /// <inheritdoc cref="Exception"/>
    /// </summary>
    public class InnerException : Exception
    {
        #region Constructors

        /// <summary>
        /// <inheritdoc cref="Exception.Exception"/>
        /// </summary>
        public InnerException()
        {
        }

        /// <summary>
        /// <inheritdoc cref="Exception.Exception(string?)"/>
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception.Message"/></param>
        public InnerException(string message) : base(message)
        {
        }

        /// <summary>
        /// <inheritdoc cref="Exception.Exception(string?, Exception?)"/>
        /// </summary>
        /// <param name="message"><inheritdoc cref="Exception.Message"/></param>
        /// <param name="innerException"><inheritdoc cref="Exception.InnerException"/></param>
        public InnerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        #endregion
    }
}
