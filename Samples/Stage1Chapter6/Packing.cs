using System;

namespace Stage1Chapter6
{
    public class Packing
    {
        private readonly Random _rnd = new Random();
        private readonly int MaxValue = 10000000;

        public int MakeValueInt()
        {
            return _rnd.Next(0, MaxValue);
        }

        public object MakeValueObject()
        {
            return _rnd.Next(0, MaxValue);
        }

        public int[] RetrieveInt()
        {
            int[] values = new int[MaxValue];
            for (var i = 0; i < MaxValue; i++)
            {
                values[i] = MakeValueInt();
            }
            return values;
        }

        public object[] RetrieveObject()
        {
            object[] values = new object[MaxValue];
            for (var i = 0; i < MaxValue; i++)
            {
                values[i] = MakeValueObject();
            }
            return values;
        }

        public void Boxing(int[] values)
        {
            object box = new object();
            for (var i = 0; i < MaxValue; i++)
            {
                box = values[i];
            }
        }
        public void UnBoxing(object[] values )
        {
            int unbox;
            for (var i = 0; i < MaxValue; i++)
            {
                unbox = (int)values[i];
            }
        }
        public void Copy(int[] values)
        {
            int copy;
            for (var i = 0; i < MaxValue; i++)
            {
                copy = values[i];
            }
        }

    }
}
