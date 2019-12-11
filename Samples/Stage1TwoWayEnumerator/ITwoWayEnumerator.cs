using System;
using System.Collections.Generic;

namespace Stage1TwoWayEnumerator
{
    public interface ITwoWayEnumerator<T> : IEnumerator<T>
    {
        bool MovePrevious();
    }
}
