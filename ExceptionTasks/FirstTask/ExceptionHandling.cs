using System;
using System.Collections.Generic;

namespace FirstTask
{
    /// <summary>
    /// Represents exception handling
    /// </summary>
    public static class ExceptionHandling
    {
        #region Public Methods

        /// <summary>
        /// Catches exceptions depending on <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Type of exception</param>
        public static void CatchAnException(ExceptionEnum exception)
        {
            try
            {
                ThrowAnException(exception);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrappedException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException.Message;
                    Console.WriteLine($"Inner Exception: '{innerException}'");
                }
            }
            catch (InnerException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        #endregion

        #region Private methods
        
        /// <summary>
        /// Throws out exception depending on <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Type of exception</param>
        private static void ThrowAnException(ExceptionEnum exception)
        {
            switch (exception)
            {
                case ExceptionEnum.NullReferenceException:
                    {
                        List<string> list = null;
                        list.Add("1");
                        break;
                    }
                case ExceptionEnum.ArithmeticException:
                    {
                        Math.Sign(Double.NaN);
                        break;
                    }
                case ExceptionEnum.InvalidCastException:
                    {
                        IConvertible conv = true;
                        _ = conv.ToChar(null);
                        break;
                    }
                case ExceptionEnum.IndexOutOfRangeException:
                    {
                        var array = new int[2];
                        _ = array[3];
                        break;
                    }
                case ExceptionEnum.InnerException:
                    {
                        throw new InnerException();
                    }
                case ExceptionEnum.WrappedException:
                    {
                        throw new WrappedException(new WrappedException().Message, new InnerException());
                    }
                case ExceptionEnum.NoException:
                    {
                        Console.WriteLine("Exception is not thrown.");
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(exception), exception, null);
            }
        }

        #endregion
    }
}
