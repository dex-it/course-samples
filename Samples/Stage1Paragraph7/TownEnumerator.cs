using System.Collections;
using System;

namespace Stage1Paragraph7
{
    class TownEnumerator : IEnumerator
    {
        string[] Towns;
        int Position = -1;

        public TownEnumerator(string[] theTowns)
        {
            Towns = new string[theTowns.Length];

            for (int i = 0; i < theTowns.Length; i++)
            { Towns[i] = theTowns[i]; }
        }

        public object Current
        {
            get
            {
                if (Position == -1)
                { throw new InvalidOperationException(); }

                if (Position >= Towns.Length)
                { throw new InvalidOperationException(); }

                return Towns[Position];
            }
        }

        public bool MoveNext()
        {
            if (Position < Towns.Length - 1)
            {
                Position++;
                return true;
            }
            else
            { return false; }
        }

        public void Reset()
        { Position = -1; }
    }
}
