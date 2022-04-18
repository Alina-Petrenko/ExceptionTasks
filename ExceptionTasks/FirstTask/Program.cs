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
        MyException,
        WrappedException,
        NoException
    }

    /// <summary>
    /// Starts the project
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of project
        /// </summary>
        static void Main()
        {
            var random = new Random();
            var exceptionArray = new ExceptionEnum[random.Next(50, 101)];

            for (int i = 0; i < exceptionArray.Length; i++)
            {
                var value = random.Next(0, 7);
                exceptionArray[i] = (ExceptionEnum)value;
            }
            foreach (var item in exceptionArray)
            {
                ExceptionHandling.ThrowAnException(item);
            }
        }
    }
}
