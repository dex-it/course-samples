using System;
using System.Collections;
using System.Collections.Generic;

namespace TestIEnumerable
{
    
    class CarPark : IEnumerable<Machine>
    {
        private Machine[] machines = new Machine[0];

        public void AddMachine(Machine machine)
        {
            Array.Resize(ref machines, machines.Length + 1);
            machines[machines.Length - 1] = machine;
        }

        public IEnumerator<Machine> GetEnumerator()
        {
            return ((IEnumerable<Machine>)machines).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Machine
    {
        public int NumberOfSeats {get; set;}
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Carrying { get; set; }
        public string Mark { get; set; }
        public Machine() { }      
        public Machine(int numberOfSeats, int weight, int height, int width, int carrying, string mark)
        {
            NumberOfSeats = numberOfSeats;
            Weight = weight;
            Height = height;
            Width = width;
            Carrying = carrying;
            Mark = mark;
        }
    }

    class PassengerCar : Machine
    {
        public string License { get; set; }
        public PassengerCar(string license,
                            int numberOfSeats,
                            int weight,
                            int height,
                            int width,
                            int carrying,
                            string mark) : base(numberOfSeats, weight, height, width, carrying, mark)
        {
            License = license;
        }
    }
    static class PassengerCars
    {
        public static PassengerCar Audi()
        {
            return new PassengerCar("",5, 123, 123, 324, 4000, "Audi");
        }
        public static PassengerCar BMW()
        {
            return new PassengerCar("", 5, 654, 700, 500, 5000, "BMW");
        }
        public static PassengerCar Mersedes()
        {
            return new PassengerCar("", 5, 700, 800, 500, 4500, "Mersedes");
        }
    }

    class Truck : Machine
    {
        public string WayBill { get; set; }
        public Truck(string wayBill,
                            int numberOfSeats,
                            int weight,
                            int height,
                            int width,
                            int carrying,
                            string mark) : base(numberOfSeats, weight, height, width, carrying, mark)
        {
            WayBill = wayBill;
        }
    }
    static class Trucks
    {
        public static Truck KAMAZ()
        {
            return new Truck("", 3, 123, 123, 324, 4000, "КАМАЗ");
        }
        public static Truck MAN()
        {
            return new Truck("", 3, 654, 700, 500, 5000, "MAN");
        }
        public static Truck VOLVO()
        {
            return new Truck("", 3, 700, 800, 500, 4500, "VOLVO");
        }
    }
}
