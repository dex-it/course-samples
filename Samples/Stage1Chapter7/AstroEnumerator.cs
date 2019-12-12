using System;
using System.Collections;
using System.Collections.Generic;
using Stage1Chapter3;

namespace Stage1Chapter7
{
    class AstroEnumerator : IEnumerator
    {
        readonly List<AstronomicalObject> _astro;
        private int _position = -1;
        public AstroEnumerator(List<AstronomicalObject> astro)
        {
            _astro = astro;
        }
        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _astro.Count)
                    throw new InvalidOperationException();
                return _astro[_position];
            }
        }

        public bool MoveNext()
        {
            if (_position < _astro.Count - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}