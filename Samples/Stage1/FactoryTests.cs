using System;
using NUnit.Framework;

namespace Stage1
{
    public class FactoryTests
    {
        [TestCase(CarType.Petrol, typeof(PetrolCar))]
        [TestCase(CarType.Diesel, typeof(DieselCar))]
        [TestCase(CarType.Electro, typeof(ElectroCar))]
        public void TestRentCar(CarType type, Type carType)
        {
            var car = new TenantCar().RentCar(type);

            Assert.AreEqual(car.GetType(), carType);
        }
    }
    
    public interface ICar
    {
        void Go(Point p); //едем в точку p
    }
    
    public class PetrolCar : ICar
    {
        public void Go(Point p)
        {
            // сжигаем бензин, едем
        }
    }
 
    public class DieselCar : ICar
    {
        public void Go(Point p)
        {
            // сжигаем дизельное топливо, едем
        }
    }
 
    public class ElectroCar : ICar
    {
        public void Go(Point p)
        {
            // разряжаем аккумулятор, едем
        }
    }
 
    public enum CarType
    {
        Petrol,
        Diesel,
        Electro
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class TenantCar
    {
        public ICar RentCar(CarType type)
        {
            if (type == CarType.Petrol)
            {
                return new PetrolCar();
            }

            if (type == CarType.Diesel)
            {
                return new DieselCar();
            }

            if (type == CarType.Electro)
            {
                return new ElectroCar();
            }
            
            throw new ArgumentOutOfRangeException(nameof(type));
        }
    }
}