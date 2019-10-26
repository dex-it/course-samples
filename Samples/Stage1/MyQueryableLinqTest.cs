using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class MyQueryableLinqTest
    {
        private List<Car> GetGeneratedCars(int count)
        {
            string[] carNames = { "FIAT", "BMW", "VW", "VOLVO" };

            bool[] isNewCar = { true, false };

            var random = new Random();

            var cars = new List<Car>();

            for (var i = 0; i < count; i++)
            {
                var car = new Car
                {
                    Price = i,
                    ProductionDate = GetRandomDay(),
                    Name = carNames[random.Next(0, 4)],
                    IsNew = isNewCar[random.Next(0, 2)]
                };
                cars.Add(car);
            }
            return cars;

        }

        private DateTime GetRandomDay()
        {
            var random = new Random();
            var start = new DateTime(2000, 1, 1);
            var range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        [Test]
        public void Test()
        {
            var cars = GetGeneratedCars(100);

            var sortedCars = cars.Where(c => c.Name == "VW").OrderBy(car => car.ProductionDate);

            var isNewCarExist = cars.Any(car => car.IsNew);

            var allCarIsNew = cars.All(car => car.IsNew);

            var groupCars = cars.GroupBy(car => car.Name);

            foreach (IGrouping<string, Car> group in groupCars)
            {
                Console.WriteLine(group.Key + " " + group.Sum(c => c.Price));
            }

        }


        class Car
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public DateTime ProductionDate { get; set; }
            public bool IsNew { get; set; }

        }

    }

}
