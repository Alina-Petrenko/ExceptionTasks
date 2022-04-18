using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SecondTask
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
                // TODO: better call using "this."
                Log(ex.GetType().ToString(), ex.StackTrace);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Log(ex.GetType().ToString(), ex.StackTrace);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                Log(ex.GetType().ToString(), ex.StackTrace);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Log(ex.GetType().ToString(), ex.StackTrace);
            }
            catch (WrappedException ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    var innerException = ex.InnerException.Message;
                    Console.WriteLine($"Inner Exception: '{innerException}'");
                }
                Log(ex.GetType().ToString(), ex.StackTrace);
            }
            catch (InnerException ex)
            {
                Console.WriteLine(ex.Message);
                Log(ex.GetType().ToString(), ex.StackTrace);
            }

        }

        #endregion

        #region Private Methods

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
                        Console.WriteLine("No error happened.");
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(exception), exception, null);
            }
        }

        /// <summary>
        /// Logs information about exceptions to a file
        /// </summary>
        /// <param name="name">Name of Exception</param>
        /// <param name="stackTrace">Stack Trace</param>
        private static void Log(string name, string stackTrace)
        {
            var fileName = "application.log";
            // TODO: better to save direct in base directory (debug/release folder)
            fileName = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\"), fileName);

            var methods = stackTrace.Split('.');
            var list = new List<string>();
            var stringBuilder = new StringBuilder();
            foreach (var method in methods)
            {
                if (method.Contains(')'))
                {
                    list.Add(method);
                }
            }
            for (var i = 0; i < list.Count; i++)
            {
                var atValue = " at ";
                var inValue = " in ";
                if (list[i].Contains(atValue))
                {
                    stringBuilder.AppendLine($"{list[i].Remove(list[i].IndexOf(atValue))} ");
                }
                else if (list[i].Contains(inValue))
                {
                    stringBuilder.AppendLine($"{list[i].Remove(list[i].IndexOf(inValue))} ");
                }
                else
                {
                    stringBuilder.Append(list[i]);
                }
            }
            File.AppendAllText(fileName, $"Exception: {name}, The methods that threw the exception: {stringBuilder}" + Environment.NewLine);
        }

        #endregion
    }
}
