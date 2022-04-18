using System;

namespace FirstTask
{
    /// <summary>
    /// Represents business exception
    /// </summary>
    public class WrappedException : Exception
    {
        #region Constructors
        /// <summary>
        /// Sets initial values
        /// </summary>
        public WrappedException() : base()
        {
        }

        /// <summary>
        /// Sets initial values
        /// </summary>
        /// <param name="message">Message</param>
        public WrappedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Sets initial values
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="innerException">Inner Exception</param>
        public WrappedException(string message, InnerException innerException) : base(message, innerException)
        {
        }
        #endregion
    }
}
