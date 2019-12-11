using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stage1Chapter3;

namespace Stage1TwoWayEnumerator
{
    public class ListTwoWayEnumerator <T> : TwoWayEnumerator <T>
    {
        //private SolarSystem _sol = new SolarSystem();
        private List<T> _buffer;

        public ListTwoWayEnumerator ()
        {
        }
        public IEnumerator GetEnumerator()
        {
            return new TwoWayEnumerator<T>(_buffer.GetEnumerator());
        }


    }
}
