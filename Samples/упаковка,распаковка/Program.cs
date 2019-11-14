using System;
using System.Diagnostics;

namespace упаковка_распаковка
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
           Stopwatch st = new Stopwatch();
            st.Start();
            object o = i;

            st.Stop();
            string time1 = st.ElapsedTicks.ToString();
            st.Restart();
          
            i = (int)o;
            st.Stop();
            string time2 = st.ElapsedTicks.ToString();
            Console.WriteLine("Время упаковки в тиках:" + time1 + " Время расспаковки:" + time2);
            Console.ReadLine();

        }

    }
}
