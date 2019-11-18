using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stag1Paragraph4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр исходной квартиры членами ValueType
            Apartment sourceApartment = new Apartment()
            {
                Floor = 5,
                Square = 50.5,
                RoomCount = 2,
                HasBalcony = true,
                WindowsOverlooking = CompassPoints.Восток
            };

            // Создаем клон
            Apartment cloneAppartment = (Apartment)sourceApartment.Clone();

            // Вывод информации об исходной квартире
            Console.WriteLine("Исходная квартира");
            sourceApartment.PrintInfo();

            // Вывод информации о клонированной квартире
            Console.WriteLine("\nКлонированная квартира");
            cloneAppartment.PrintInfo();

            Console.ReadLine();

        }
    }
}
