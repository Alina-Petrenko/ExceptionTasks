using System;

namespace FirstTask
{
    /// <summary>
    /// <inheritdoc cref="Exception"/>
    /// </summary>
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
