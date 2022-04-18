using System;
using System.Collections.Generic;

namespace FirstTask
{
    /// <summary>
    /// Represents exception handling
    /// </summary>
    public static class ExceptionHandling
    {
        // TODO: General comment.
        // TODO: after #region should be new line, and before #endregion should be new line
        #region Public Methods
        /// <summary>
        /// Throws out exception depending on <paramref name="exception"/>
        /// </summary>
        /// <param name="exception">Type of exception</param>
        // TODO: separate logic of throwing and handling of message into separate methods
        public static void ThrowAnException(ExceptionEnum exception)
        {
            try
            {
                // TODO: use enum values in switch
                var value = Convert.ToInt32(exception);
                switch (value)
                {
                    // TODO: hard to understand what 0 means, without checking enum values
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
                            throw new WrappedException("Outer message", new InnerException("Inner message"));
                            
                            // TODO: why do we need this try/catch?
                            // TODO: we need to throw WrappedException exception like above
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
                    // TODO: not all values checked
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
