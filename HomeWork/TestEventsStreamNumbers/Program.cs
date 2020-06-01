using System;

namespace TestEventsNumbersStream
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersStream numbersStream = new NumbersStream();

            Console.WriteLine("Введите порог процента");
            int percentageThreshold;
            while (!int.TryParse(Console.ReadLine(), out percentageThreshold))
            {
                Console.WriteLine("Вы ввели неверное число");
            }

            NumberAnalyzer numberAnalyzer = new NumberAnalyzer(percentageThreshold);

            numbersStream.CurrentNumberChanged += (sender, eventArgs) =>
            {
                MessageOnConsole(eventArgs.ToString());
                numberAnalyzer.Analyz(eventArgs);
            };
            
            numberAnalyzer.BigDifference += (sender, eventArgs) =>
            {
                MessageOnConsole(
                    String.Format("Внимание порог в {0} % превышен! Отличие составляет {1} %.",
                        percentageThreshold, eventArgs.ToString())
                );
            };
            Console.WriteLine("Запускаю поток");
            numbersStream.StartStream();
        }

        static void MessageOnConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
