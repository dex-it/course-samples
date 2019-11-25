using System;
using System.Collections.Generic;
using Stage1Chapter10;

namespace Stage1Chapter11
{
    public class PlanetBook
    {

        public readonly Dictionary<AstronomicalObjectEqual, int> _planetDictionary = new Dictionary<AstronomicalObjectEqual, int>();

        public void AddAstronomicalObject(AstronomicalObjectEqual planet, int numberFromSun)
        {
            if (!_planetDictionary.ContainsKey(planet))
            {
                _planetDictionary.Add(planet, numberFromSun);
            }
            else
            {
                //return;
                throw new InvalidOperationException("This key is already in the collection.");
            }
        }

        public int GetNumberFromSun(AstronomicalObjectEqual planet)
        {
            int res = 0;

            foreach (var p in _planetDictionary)
            {
                if (p.Key.GetHashCode() == planet.GetHashCode())
                {
                    res = p.Value;
                    break;
                }
            }

            return res;
        }


    }
}
