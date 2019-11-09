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
            if (g != null)
            {
                return this.Area.CompareTo(g.Area);
            }
            else
            {
                throw new Exception("Невозможно сравнить два объекта");
            }
        }
        public abstract void Info();
    }
}
