using System;


namespace _18_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("TestIComparable.SomeFigure, 9_TestIComparable", true, true);

            Console.ReadKey();
        }
    }
}
