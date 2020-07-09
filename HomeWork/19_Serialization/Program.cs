using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _19_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] CarArray = FillTheArray();
            Serialize(CarArray);

            Car[] DeserializeCarArray = Deserialize();

            foreach (var car in DeserializeCarArray)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadKey();
        }

        public static Car[] FillTheArray ()
        {
            return new Car[] {
                new Car
                {
                    YearOfIssue = 2010,
                    Color = Colors.Black,
                    engine = new Car.Engine{TypeOfFuel = TypeOfFuel.Petrol95, Volume = 2.0}
                },
                new Car 
                {
                    YearOfIssue = 2015,
                    Color = Colors.Silver,
                    engine = new Car.Engine { TypeOfFuel = TypeOfFuel.Diesel, Volume = 2.2 }
                }, new Car
                {
                    YearOfIssue = 1993,
                    Color = Colors.Red,
                    engine = new Car.Engine { TypeOfFuel = TypeOfFuel.Petrol92, Volume = 1.6 }
                } };
        }

        public static void Serialize(Car[] cars)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car[]));
            using (FileStream fs = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, cars);
            }
        }

        public static Car[] Deserialize()
        {
            Car[] cars = new Car[] { };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Car[]));

            using (FileStream fs = new FileStream("cars.xml", FileMode.OpenOrCreate))
            {
                cars = (Car[])xmlSerializer.Deserialize(fs);
            }

            return cars;
        }
    }
}
