using System;
using System.Threading;
using System.Linq;

namespace Потоки
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] mas1 = new double[10];
            double[] mas2 = new double[100000000];
            double Sum1 = 0;
            var locker = new object();
            Mutex mutexObj = new Mutex();

            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = random.Next(100);
                Console.WriteLine(mas1[i]);
            }
            bool acquiredLock = false;
            int n = mas1.Length;
            ThreadPool.QueueUserWorkItem(_ =>
            {

                while (n-- > 0)
                {
                    lock (locker)
                    {
                        Sum1 += mas1[n];
                    }
                }


                if (n==0) mutexObj.ReleaseMutex();
            });


            mutexObj.WaitOne();
            Console.WriteLine("Cумма =" + Sum1);
            Console.ReadLine();
        }
    }
}
