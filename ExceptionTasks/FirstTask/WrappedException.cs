using System;

namespace FirstTask
{
    /// <summary>
    /// <inheritdoc cref="Exception"/>
    /// </summary>
    public class WrappedException : Exception
    {
        #region Constructors
        
        /// <inheritdoc cref="Exception"/>
        public WrappedException()
        {
        }
        
        ///  <inheritdoc cref="Exception"/>
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
