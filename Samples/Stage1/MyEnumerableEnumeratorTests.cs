using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Stage1
{
    [TestFixture]
    public class EnumerableEnumeratorTests
    {
        [Test]
        public void EnumerableTest()
        {
            var cars = new Car[3]
           {
                 new Car{Name = "Audi", Number = "A345EK"},
                 new Car{Name = "Kia", Number = "A346EK"},
                 new Car{Name = "Fiat", Number = "A347EK"}
           };

            var parking = new Parking(cars);

            foreach (var car in parking)
            {
                Console.WriteLine((car as Car)?.Name);
            }


            var parkingEnumerator = parking.GetEnumerator();

            while (parkingEnumerator.MoveNext())
            {
                var car = (Car)parkingEnumerator.Current;
                Console.WriteLine(car?.Number);
            }
            parkingEnumerator.Reset();
        }

    }

    public class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }
    }
    public class Parking
    {
        private Car[] _cars;

        public Parking(Car[] carArray)
        {
            if (carArray != null)
            {
                _cars = carArray;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new ParkingEnum(_cars);
            
            //return _cars.GetEnumerator();  ??
         }

    }
    public class ParkingEnum : IEnumerator
    {
        private Car[] _car;

        private int _position = -1;

        public ParkingEnum(Car[] list)
        {
            _car = list;
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _car.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;

        private Car Current
        {
            get
            {
                try
                {
                    return _car[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


    }
    
}