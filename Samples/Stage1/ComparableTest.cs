using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class ComparableTest
    {
        [Test]
        public void Test1()
        {
            var collection = Enumerable.Range(1, 10).Select(x => new SampleTestObj() {Code = x});

            Assert.Throws<ArgumentException>(() =>
            {
                // операция сортировки бросит ошибку
                var sorted = collection.OrderBy(obj => obj).ToArray();
            });
        }

        private class SampleTestObj
        {
            public int Code { get; set; }
            public string Message { get; set; }
        }

        [Test]
        public void Test2()
        {
            ArrayList temperatures = new ArrayList();
            // Initialize random number generator.
            Random rnd = new Random();

            // Generate 10 temperatures between 0 and 100 randomly.
            for (int ctr = 1; ctr <= 10; ctr++)
            {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            // Sort ArrayList.
            temperatures.Sort();

            foreach (Temperature temp in temperatures)
            {
                Console.WriteLine(temp.Fahrenheit);
            }

            // развернем лист
            temperatures.Reverse();
            Console.WriteLine("---");

            // или Linq sort
            foreach (Temperature temp in temperatures.OfType<Temperature>().OrderBy(x => x))
            {
                Console.WriteLine(temp.Fahrenheit);
            }
        }

        private class Temperature : IComparable
        {
            // The temperature value
            protected double temperatureF;

            public int CompareTo(object obj)
            {
                if (obj == null) return 1;

                Temperature otherTemperature = obj as Temperature;
                if (otherTemperature != null)
                    return this.temperatureF.CompareTo(otherTemperature.temperatureF);
                else
                    throw new ArgumentException("Object is not a Temperature");
            }

            public double Fahrenheit
            {
                get { return this.temperatureF; }
                set { this.temperatureF = value; }
            }

            public double Celsius
            {
                get { return (this.temperatureF - 32) * (5.0 / 9); }
                set { this.temperatureF = (value * 9.0 / 5) + 32; }
            }
        }
    }
}