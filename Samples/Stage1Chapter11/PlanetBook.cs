using System;
using System.Collections.Generic;
using Stage1Chapter10;

namespace Stage1Chapter11
{
    public class PlanetBook
    {
        public int MaxRange { get; set; } = 0;

        public readonly Dictionary<AstronomicalObjectEqual, int> _planetDictionary = new Dictionary<AstronomicalObjectEqual, int>();


        public event EventHandler ListEmptyReached;
        public event EventHandler ListMaxRangeReached;

        protected virtual void OnListEmptyReached(EventArgs e)
        {
            EventHandler handler = ListEmptyReached;
            handler?.Invoke(this, e);
        }
        protected virtual void OnListMaxRangeReached(EventArgs e)
        {
            EventHandler handler = ListMaxRangeReached;
            handler?.Invoke(this, e);
        }

        public void AddAstronomicalObject(AstronomicalObjectEqual planet, int numberFromSun)
        {
            if (!_planetDictionary.ContainsKey(planet))
            {
                _planetDictionary.Add(planet, numberFromSun);
                if (_planetDictionary.Count > MaxRange)
                {
                    ListMaxRangeReached?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                throw new InvalidOperationException("This key is already in the collection.");
            }
        }

        public void RemoveAstronomicalObject(AstronomicalObjectEqual planet)
        {
            if (_planetDictionary.ContainsKey(planet))
            {
                _planetDictionary.Remove(planet);
                if (_planetDictionary.Count == 0)
                {
                    ListEmptyReached?.Invoke(this, EventArgs.Empty);
                }
            }
            else
            {
                throw new InvalidOperationException("This key is not in the collection.");
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
