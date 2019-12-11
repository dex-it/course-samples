using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1TwoWayEnumerator
{
    public interface ITwoWayEnumerator<T> : IEnumerator<T>
    {
        bool MovePrevious();
    }
}
