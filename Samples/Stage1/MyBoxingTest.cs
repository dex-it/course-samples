using System;
using System.Diagnostics;
using System.Threading;
using NUnit.Framework;
using ThreadState = System.Threading.ThreadState;

namespace Stage1
{
    public class MyBoxingTest
    {
        Stopwatch _stopwatch=new Stopwatch();

        [Test]
       public void Test()
       {
           object  q=0;
            _stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                 q=i;
            }
            _stopwatch.Stop();

            var boxingTime = _stopwatch.ElapsedMilliseconds;
          
            _stopwatch.Reset();
            _stopwatch.Start();
            object [] mas=new object[1000000];

           
            foreach (object j in mas)
            {
                
            }
            _stopwatch.Stop();
            var unboxingTime = _stopwatch.ElapsedMilliseconds;

            Console.WriteLine(boxingTime);
            Console.WriteLine(unboxingTime);
        }
    }
}