using System;

namespace FirstTask
{
    /// <summary>
    /// Represents business exception
    /// </summary>
    public class InnerException : Exception
    {
        #region Constructors
        /// <summary>
        /// Sets initial values
        /// </summary>
        public InnerException() : base()
        {
        }

        /// <summary>
        /// Sets initial values
        /// </summary>
        /// <param name="message">Message</param>
        public InnerException(string message) : base(message)
        {
        }

        /// <summary>
        /// Sets initial values
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="innerException">Inner Exception</param>
        public InnerException(string message, Exception innerException) : base(message, innerException)
        {
        }
        #endregion
    }
}
