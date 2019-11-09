using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1Chapter9
{
    abstract class GeometricShape: IComparable
    {
        public abstract decimal Area { get; }

        public int CompareTo(object o)
        {
            GeometricShape g = o as GeometricShape;

            if (this.Area < g.Area)
                 return 1;
            if (this.Area > g.Area)
                 return -1;
            else
                 return 0;

        }
        public abstract void Info();
    }
}
