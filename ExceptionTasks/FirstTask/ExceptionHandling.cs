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
        /// Throws out exception depending on <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Type of exception</param>
        public static void ThrowAnException(ExceptionEnum exception)
        {
            try
            {
                var value = Convert.ToInt32(exception);
                switch (value)
                {
                    case 0:
                        {
                            List<string> list = null;
                            list.Add("1");
                            break;
                        }
                    case 1:
                        {
                            Math.Sign(Double.NaN);
                            break;
                        }
                    case 2:
                        {
                            IConvertible conv = true;
                            var ch = conv.ToChar(null);
                            break;
                        }
                    case 3:
                        {
                            var array = new int[2];
                            var item = array[3];
                            break;
                        }
                    case 4:
                        {
                            throw new InnerException();
                        }
                    case 5:
                        {
                            try
                            {
                                throw new InnerException();
                            }
                            catch (InnerException ex)
                            {
                                try
                                {

                                    throw new WrappedException();
                                }
                                catch
                                {
                                    throw new WrappedException((new WrappedException()).Message, ex);
                                }
                            }
                            throw new WrappedException();
                        }
                    default:
                        {
                            break;
                        }
                }
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
    }
}
