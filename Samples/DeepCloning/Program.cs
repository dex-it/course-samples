using System;

namespace DeepCloning
{
    class Program
    {
        static void Main(string[] args)
        {
            House sourceHouse = new House();
            sourceHouse.RoomsList.Add("зал");
            sourceHouse.RoomsList.Add("спальня");
            sourceHouse.RoomsList.Add("детская комната");
            sourceHouse.RoomsList.Add("кухня");
            sourceHouse.RoomsList.Add("ванная комната");

            House cloneHouse = sourceHouse.DeepCopy();

            Console.ReadLine();

        }
    }
}
