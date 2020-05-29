using System;

namespace TestEventsNumbersStream
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersStream numbersStream = new NumbersStream();
            numbersStream.CurrentNumberChanged += (sender, eventArgs) =>
            {
                MessageOnConsole(eventArgs.ToString());
            };
            numbersStream.StartStream();
        }

        static void MessageOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
