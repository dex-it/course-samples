using Stage1Chapter3;
using System.Collections;
using System.Collections.Generic;

namespace Stage1Chapter7
{
    public class SolarSystemEnum : SolarSystem
    {
        private SolarSystem _sol = new SolarSystem();

        public IEnumerator GetEnumerator()
        {
            return new AstroEnumerator(_sol.GetListAstroObjects());
        }
    }
}