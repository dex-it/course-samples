using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIEnumerable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarPark carPark = new CarPark();
            carPark.AddMachine(Trucks.VOLVO());
            carPark.AddMachine(PassengerCars.BMW());                      

            foreach (Machine machine in carPark)
            {
                Console.WriteLine(machine.Mark);
            }

            var enumerator = carPark.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Mark + " " + enumerator.Current.Carrying);
            }
            Console.ReadLine();
        }
    }
}
