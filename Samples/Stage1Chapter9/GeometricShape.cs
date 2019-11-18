using System;


namespace Stage1Chapter9
{
    abstract class GeometricShape: IComparable
    {
        public abstract decimal Area { get; }

        public int CompareTo(object o)
        {
            var g = o as GeometricShape;

            if (g != null && Area < g.Area)
                 return 1;
            if (g != null && Area > g.Area)
                 return -1;
            return 0;

        }
        public abstract void Info();
    }
}
