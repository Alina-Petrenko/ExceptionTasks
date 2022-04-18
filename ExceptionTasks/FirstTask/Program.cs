using System;

namespace FirstTask
{
    /// <summary>
    /// Represents an enum of exceptions
    /// </summary>
    public enum ExceptionEnum
    {
        NullReferenceException,
        ArithmeticException,
        InvalidCastException,
        IndexOutOfRangeException,
        InnerException,
        WrappedException,
        NoException
    }

    /// <summary>
    /// Starts the project
    /// </summary>
    class Program
    {
        /// <summary>
        /// Entry point of project
        /// </summary>
        static void Main()
        {
            var random = new Random();
            var exceptionArray = new ExceptionEnum[random.Next(50, 101)];

            for (var i = 0; i < exceptionArray.Length; i++)
            {
                var value = random.Next(0, 7);
                exceptionArray[i] = (ExceptionEnum)value;
            }
            foreach (var item in exceptionArray)
            {
                ExceptionHandling.CatchAnException(item);
            }
        }
    }
}
