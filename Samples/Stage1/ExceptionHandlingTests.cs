using System;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ExceptionHandlingTests
    {
        [Test(Description = "Неперехваченное исключение")]
        public void UnhandledExceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                int x = 5;
                int y = x / 0; // Деление на ноль генерирует исключение System.DivideByZeroException
                Console.WriteLine($"Результат: {y}"); // Этот код не исполнится
            });
        }

        [Test(Description = "Перехваченное исключение")]
        public void CaughtExceptionTest()
        {
            try
            {
                int x = 5;
                int y = x / 0; // Деление на ноль генерирует исключение System.DivideByZeroException
                Console.WriteLine($"Результат: {y}"); // Этот код не исполнится
            }
            catch
            {
                Console.WriteLine("Возникло исключение"); // Этот текст будет выведен
            }
        }

        [Test(Description = "Перехват исключения определенного типа")]
        public void CaughtDivideByZeroExceptionTest()
        {
            try
            {
                int x = 5;
                int y = x / 0; // Деление на ноль генерирует исключение System.DivideByZeroException
                Console.WriteLine($"Результат: {y}"); // Этот код не исполнится
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Перехвачено исключение DivideByZeroException"); // Этот текст будет выведен
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Перехвачено исключение: {exception.Message}"); // Этот код не исполнится
            }
        }

        [Test(Description = "Явная генерация исключения")]
        public void ThrowExceptionTest()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                try
                {
                    int x = 0;
                    if (x == 0)
                    {
                        throw new ArgumentException("Недопустимое значение переменной"); // Явная генерация исключения System.ArgumentException
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Перехвачено исключение System.ArgumentException"); // Этот текст будет выведен
                    throw; // Перехваченное исключение будет сгенерировано заново
                }
            });
        }

        [Test(Description = "Пример try-catch-finally. Явная генерация пользовательского исключения, его перехват и повторная генерация.")]
        public void TryCatchFinallyTest()
        {
            Assert.Throws<MyException>(() =>
            {
                try
                {
                    int x = 0;
                    if (x == 0)
                    {
                        throw new MyException("Недопустимое значение переменной"); // Явная генерация пользовательского исключения
                    }
                }
                catch (MyException)
                {
                    Console.WriteLine("Перехвачено исключение MyException"); // Этот текст будет выведен
                }
                finally
                {
                    Console.WriteLine("finally блок выполняется всегда"); // Этот текст будет выведен
                }
            });
        }

        /// <summary>
        /// Пример пользовательского исключения
        /// </summary>
        public class MyException : Exception
        {
            public MyException()
            {
            }

            public MyException(string message)
                : base(message)
            {
            }

            public MyException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
    }
}