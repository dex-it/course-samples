using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace StageConsole1App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, All");

            // 
            string str = "Пример побуквенного вывода строки";
            foreach (char o in str)
            {
                Console.Write(o);
            }
            var t = new Thread(PrintY);
            t.Start();

            while (true)
                Console.Write("x?");

            _ = Console.ReadLine();
        }
      //  [Timeout(100)]
        static void PrintY()
        {
            while (true)
            {
                Console.Write("y!");
            
                }
        }
    }
}
