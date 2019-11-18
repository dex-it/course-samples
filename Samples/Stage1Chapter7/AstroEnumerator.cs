using System.Collections;
namespace Stage1Chapter7
{
    class AstroEnumerator : IEnumerator
    {
        readonly AstronomicalObject[] _astro;
        private int _position = -1;
        public AstroEnumerator(AstronomicalObject[] astro)
        {
            _astro = astro;
        }
        public object Current => _astro[_position];

        public bool MoveNext()
        {
            if (_position < _astro.Length - 1)
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