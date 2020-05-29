using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestIComparable
{
    
    class SomeFigure: IComparable<SomeFigure>
    {
        private int a;
        private int b;
        private int area;
        public int A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
                CountArea();
            }
        }
        public int B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
                CountArea();
            }
        }        
        public int Area
        {
            get
            {
                return area;
            }                        
        }
        public SomeFigure()
        {
            
        }
        public SomeFigure (int a, int b)
        {
            this.a = a;
            this.b = b;
            CountArea();
        }
        private void CountArea()
        {
            area = a * b;
        }

        public int CompareTo(SomeFigure other)
        {
            return this.area.CompareTo(other.area);
        }
    }

    class CompareSomeFigureToA : IComparer<SomeFigure>
    {
        public int Compare([AllowNull] SomeFigure x, [AllowNull] SomeFigure y)
        {
            return x.A.CompareTo(y.A);
        }
    }


}
