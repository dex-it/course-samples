using System;
using System.Collections;
using System.Collections.Generic;

namespace Stage1TwoWayEnumerator
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4 ,5};

            ITwoWayEnumerator<int> enumerator = TwoWayEnumeratorHelper.GetTwoWayEnumerator(list);
            /*
            foreach (var el in list)
            {
                
                var element = enumerator.Current;
                Console.WriteLine($"--> {el}");
            }
            */

            while (enumerator.MovePrevious())
            {
                var element = enumerator.Current;
                Console.WriteLine($"--> {element}");
            }
           
            Console.ReadLine();







        }

     

    }
}