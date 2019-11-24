using System;
using System.Collections.Generic;
using Stage1Chapter3;
using Stage1Chapter10;

namespace Stage1Chapter11
{
    public class PlanetBook
    {

        public readonly Dictionary<AstronomicalObjectEqual, int> _planetDictionary = new Dictionary<AstronomicalObjectEqual, int>();

        public void AddAstronomicalObject(AstronomicalObjectEqual planet, int numberFromSun)
        {
            _planetDictionary.Add(planet, numberFromSun);
        }

        public int GetNumberFromSun(AstronomicalObjectEqual planet)
        {
            int res = 0;

            foreach (var p in _planetDictionary)
            {

                if (p.Key.GetHashCode() == planet.GetHashCode())
                {
                    res = p.Value;
                }
                
            }

            return res;
        }


    }
}
