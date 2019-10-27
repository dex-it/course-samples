    using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Stage1
{
    public class MySerializationTest
    {
        [Serializable]
        public class Car
        {
            public Car()
            {
                
            }
            
            public string Name { get; set; }
            public string Number { get; set; }
            public Person CarOwner { get; set; }
        }
     
        [Serializable]
        public class Person
        {
            public Person()
            {
                
            }
            
            public string Name { get; set; }
            public Car Car { get; set; }
        }

        Car car=new Car
        {
            Name = "VW",
            Number = "T577EK",
            CarOwner = new Person
            {
                Name ="PersonName",
            }
        };
        
        
        [Test]
        public void BinaryTest()
        {
            car.CarOwner = new Person
            {
                Car = car
            };
            var bf = new BinaryFormatter();
            
            using (var stream=new FileStream("BinaryTest", FileMode.OpenOrCreate))
            {
                bf.Serialize(stream,car);
                
                stream.Position = 0;
                
                var deserializedCar= bf.Deserialize(stream) as Car;
                Console.WriteLine(deserializedCar?.Name);
            }

        }

        [Test]
        public void XmlTest()
        {
//            car.CarOwner = new Person InvalidOperationException
//            {
//                Car = car   
//            };

            Console.WriteLine(car.CarOwner.Name);
            XmlSerializer formatter = new XmlSerializer(typeof(Car));
            Car deserilizeCar;
 
            using (var stream = new MemoryStream())
            {
                formatter.Serialize(stream,car );

                var text = Encoding.Default.GetString(stream.ToArray());
                Console.WriteLine("Сериализованные данные:\n{0}",text);
                stream.Position = 0;
                
                deserilizeCar = formatter.Deserialize(stream) as Car;
            }
            
            Console.WriteLine(deserilizeCar?.Number);
        }

        
        [Test]
        public void JsonTest()
        {
          //  car.CarOwner = new Person { Car = car }; exception, LoopDetected
            
            var json = JsonConvert.SerializeObject(car);
            Console.WriteLine(json);
            
            var deserializedCar = JsonConvert.DeserializeObject<Car>(json);
            
            Console.WriteLine(deserializedCar.Name);
        }
    }
}